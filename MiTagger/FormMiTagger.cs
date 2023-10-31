using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;
using System.Security.Policy;

namespace MiTagger
{
    public partial class MiTagger : Form
    {
        const int TOKENCOUNT = 7;
        string m_readPath = "";
        string m_writePath = "";

        //---------------------------------------------------------------------------
        public MiTagger()
        {
            InitializeComponent();
        }
        //---------------------------------------------------------------------------
        private void MiTagger_Load(object sender, EventArgs e)
        {
            this.AllowDrop = true;
            int[] arr = {60, 90};
            SetListBoxTabs(ListBoxInfo, arr);

            LabelCredit.Text = "Credits: https://github.com/mono/taglib-sharp";

            string[] arguments = Environment.GetCommandLineArgs();
            // NOTE: arguement[0] has the exe file name
            if (arguments.Length == 2)
            {
                if (System.IO.File.Exists(arguments[1]))
                    ReadTags(arguments[1]);
            }
        }
        //---------------------------------------------------------------------------
        private void MiTagger_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        //---------------------------------------------------------------------------
        private void MiTagger_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int len = FileList.Length;
            if (len > 0)
            {
                if (len > 1 && len < 20)
                {
                    while (--len != 0)
                      SpawnOurself(FileList[len]);
                }
                ReadTags(FileList[0]);
            }
        }
        //---------------------------------------------------------------------------
        private void SpawnOurself(String filePath)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = Application.ExecutablePath;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = "\"" + filePath + "\"";
            try { Process.Start(startInfo); }
            catch {}
        }
        //---------------------------------------------------------------------------
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    ReadTags(openFileDialog.FileName);
            }
        }
        //---------------------------------------------------------------------------
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteTags(m_writePath, checkBoxClearPreExistingTags.Checked);
        }
        //---------------------------------------------------------------------------
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.savefiledialog?view=windowsdesktop-7.0
                //saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                //saveFileDialog.FilterIndex = 2;
                saveFileDialog.OverwritePrompt = false;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    WriteTags(saveFileDialog.FileName, checkBoxClearPreExistingTags.Checked);
            }
        }
        //---------------------------------------------------------------------------
        private void ReadTags(String filePath)
        {
            if (String.IsNullOrEmpty(filePath))
                return;

            TagLib.File file = null;
            try
            {
                file = TagLib.File.Create(filePath);
                m_readPath = filePath;
            }
            catch
            {
                m_readPath = "";
            }

            var fileInfo = new FileInfo(filePath);

            if (m_readPath.Length == 0)
            {
                try
                {
                    m_readPath = new Uri(fileInfo.FullName).ToString();
                    FileAbstraction fa = new FileAbstraction(m_readPath);
                    if (fa != null)
                    {
                        file = TagLib.File.Create(fa.Name);
                    }
                    else
                    {
                        MessageBox.Show("Unable to create fileAbstraction for: " + fa.Name);
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show($"Unsupported file: {filePath}");
                    m_readPath = "";
                    return;
                }
            }

            m_writePath = m_readPath;

            if (file.PossiblyCorrupt)
                LabelPath.Text = "(POSSIBLY CORRUPT!) " + m_readPath;
            else
                LabelPath.Text = m_readPath;

            EditArtists.Text = ArrayToCommaString(file.Tag.AlbumArtists);
            EditGenres.Text = ArrayToCommaString(file.Tag.Genres);
            EditTitle.Text = StripTab(file.Tag.Title);
            EditAlbum.Text = StripTab(file.Tag.Album);
            EditYear.Text = StripTab(file.Tag.Year.ToString());
            EditTrack.Text = StripTab(file.Tag.Track.ToString());

            ListBoxInfo.Items.Clear();

            foreach (var codec in file.Properties.Codecs)
            {
                if (codec is IAudioCodec acodec && (acodec.MediaTypes & MediaTypes.Audio) != MediaTypes.None)
                {
                    ListBoxInfo.Items.Add($"Audio Properties\t: {acodec.Description}");
                    ListBoxInfo.Items.Add($"Bit Rate:\t{acodec.AudioBitrate}");
                    ListBoxInfo.Items.Add($"Sample Rate:\t{acodec.AudioSampleRate}");
                    ListBoxInfo.Items.Add($"Channels:\t{acodec.AudioChannels}\n");
                }

                if (codec is IVideoCodec vcodec && (vcodec.MediaTypes & MediaTypes.Video) != MediaTypes.None)
                {
                    ListBoxInfo.Items.Add($"Video Properties:\t{vcodec.Description}");
                    ListBoxInfo.Items.Add($"Width:\t{vcodec.VideoWidth}");
                    ListBoxInfo.Items.Add($"Height:\t{vcodec.VideoHeight}\n");
                }
            }

            TagLib.MediaTypes mt = file.Properties.MediaTypes;
            if (mt != MediaTypes.None)
                ListBoxInfo.Items.Add($"Media Type:\t{mt}\n");

            ListBoxInfo.Items.Add($"Duration:\t{file.Properties.Duration}\n");
            ListBoxInfo.Items.Add($"File Size:\t{fileInfo.Length}");
        }
        //---------------------------------------------------------------------------
        private bool WriteTags(String filePath, bool bClearPreExistingTags)
        {
            if (String.IsNullOrEmpty(filePath))
                return false;

            TagLib.File file = null;
            try
            {
                file = TagLib.File.Create(filePath);
                m_readPath = filePath;
            }
            catch
            {
                m_readPath = "";
            }

            var fileInfo = new FileInfo(filePath);

            if (m_readPath.Length == 0)
            {
                try
                {
                    m_readPath = new Uri(fileInfo.FullName).ToString();
                    FileAbstraction fa = new FileAbstraction(m_readPath);
                    if (fa != null)
                    {
                        file = TagLib.File.Create(fa.Name);
                    }
                    else
                    {
                        MessageBox.Show("Unable to create fileAbstraction for: " + fa.Name);
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show($"Unsupported file: {filePath}");
                    m_readPath = "";
                    return false;
                }
            }

            string artists = ArrayToCommaString(file.Tag.AlbumArtists);
            string genres = ArrayToCommaString(file.Tag.Genres);
            string title = StripTab(file.Tag.Title);
            string album = StripTab(file.Tag.Album);
            string year = StripTab(file.Tag.Year.ToString());
            string track = StripTab(file.Tag.Track.ToString());

            // Clear pre-existing tags during "Save As"
            if (bClearPreExistingTags)
                file.Tag.Clear();

            var tagsCount = 0;
            if (bClearPreExistingTags || artists != EditArtists.Text)
            {
                file.Tag.AlbumArtists = CommaStringToArray(EditArtists.Text);
                tagsCount++;
            }
            if (bClearPreExistingTags || genres != EditGenres.Text)
            {
                file.Tag.Genres = CommaStringToArray(EditGenres.Text);
                tagsCount++;
            }
            if (bClearPreExistingTags || title != EditTitle.Text)
            {
                file.Tag.Title = EditTitle.Text;
                tagsCount++;
            }
            if (bClearPreExistingTags || album != EditAlbum.Text)
            {
                file.Tag.Album = EditAlbum.Text;
                tagsCount++;
            }
            if (bClearPreExistingTags || year != EditYear.Text)
            {
                int iYear = -1;
                try
                {
                    iYear = Convert.ToInt32(EditYear.Text);
                }
                catch { }

                if (iYear >= 0)
                {
                    file.Tag.Year = (uint)iYear;
                    tagsCount++;
                }
            }
            if (bClearPreExistingTags || track != EditTrack.Text)
            {
                int iTrack = -1;
                try
                {
                    iTrack = Convert.ToInt32(EditTrack.Text);
                }
                catch { }

                if (iTrack >= 0)
                {
                    file.Tag.Track = (uint)iTrack;
                    tagsCount++;
                }
            }
            if (tagsCount > 0)
            {
                try
                {
                    file.Save();
                    m_writePath = filePath;
                    LabelPath.Text = m_writePath;
                    MessageBox.Show($"Wrote {tagsCount} changed tags to \"{m_writePath}\"!");
                }
                catch
                {
                    MessageBox.Show($"Unable to write {tagsCount} tags to \"{m_writePath}\"!");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("No changed tags to write!");
            }
            return true;
        }
        //---------------------------------------------------------------------------
        private void SetListBoxTabs(ListBox lst, IEnumerable<int> tabs)
        {
            // Make sure the control will use them.
            lst.UseTabStops = true;
            lst.UseCustomTabOffsets = true;

            // Get the control's tab offset collection.
            ListBox.IntegerCollection offsets = lst.CustomTabOffsets;

            // Define the tabs.
            foreach (int tab in tabs)
            {
                offsets.Add(tab);
            }
        }
        //---------------------------------------------------------------------------
        private void ButtonCopyTags_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.Clear();
                String sTags = GetTagsAsString();
                if ((sTags.Length > 0))
                    Clipboard.SetText(sTags);
                else
                    MessageBox.Show("Unable to copy tags to clipboard!");
            }
            catch
            {
                MessageBox.Show("Unable to copy tags to clipboard!");
            }
        }
        //---------------------------------------------------------------------------
        private void ButtonPasteTags_Click(object sender, EventArgs e)
        {
            try
            {
                String sTags = Clipboard.GetText();
                int retCode = SetTagsFromString(sTags);
                if (retCode == -1)
                    MessageBox.Show("Select \"Copy Tags\" before you can \"Paste Tags\"!");
                else if (retCode< 0)
                    MessageBox.Show("Unable to retreive tags from clipboard!");
            }
            catch
            {
                MessageBox.Show("Unable to retreive tags from clipboard!");
            }
        }
        //---------------------------------------------------------------------------
        private string ArrayToCommaString(string[] sArray){
            string sTabStr = "";
            foreach (string s in sArray){
                String sStrip = StripTab(s);
                if (sStrip.Length > 0)
                    sTabStr += sStrip + ", ";
            }
            while (sTabStr.EndsWith(",") || sTabStr.EndsWith(" "))
                sTabStr = sTabStr.Substring(0, sTabStr.Length - 1);
            return sTabStr;
        }
        //---------------------------------------------------------------------------
        private string[] CommaStringToArray(string sCommaString){
            return sCommaString.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        }
        //---------------------------------------------------------------------------
        // sIn has a comma-seperated list of TOKENCOUNT strings each delimited by the tab-character
        // (NOTE: I used tab-char instead of quotes around each token because we might have a quote
        // char used in one of the song's tags...)
        private int SetTagsFromString(String sIn)
        {
            try
            {
                String[] sl = new String[TOKENCOUNT];

                int ii = 0; // index into sl[]
                for (; ii<TOKENCOUNT; ii++)
                {
                    int len = sIn.Length;
                    if (len == 0) break;
                    int pos = sIn.LastIndexOf(','); // get "ENDSMTAGS" terminator index
                    if (pos >= 0)
                    {
                        String sTok = sIn.Substring(pos + 1, len - pos - 1);
                        sIn = sIn.Substring(0, pos);
                        sl[ii] = sTok; // add tokens except for first
                    }
                    else
                        break;
                }
                if (ii != TOKENCOUNT - 1)
                    return -1;
                sl[ii] = sIn; // add first token (what's left of sIn after other tokens snipped off...)

                String sIdentifier = StripTab(sl[0]);
                if (sIdentifier != "ENDSMTAGS")
                    return -2;
                EditTitle.Text = StripTab(sl[6]);
                EditArtists.Text = StripTab(sl[5]);
                EditAlbum.Text = StripTab(sl[4]);
                EditGenres.Text = StripTab(sl[3]);
                EditYear.Text = StripTab(sl[2]);
                EditTrack.Text = StripTab(sl[1]);
            }
            catch
            {
                return -3;
            }
            return 0;
        }
        //---------------------------------------------------------------------------
        // strips quotes (actually the tab character!) from quoted string
        // (NOTE: allow for string having extraneous leading/trailing blanks)
        private String StripTab(String sIn)
        {
            if (String.IsNullOrEmpty(sIn))
                return "";
            return sIn.Trim().Replace("\t", "");
        }
        //---------------------------------------------------------------------------
        //http://docwiki.embarcadero.com/RADStudio/Sydney/en/UTF-8_Conversion_Routines
        private String GetTagsAsString()
        {
            String sOut = "";

            try
            {
                sOut += "\t" + EditTitle.Text + "\t," +
                        "\t" + EditArtists.Text + "\t," +
                        "\t" + EditAlbum.Text + "\t," +
                        "\t" + EditGenres.Text + "\t," +
                        "\t" + EditYear.Text + "\t," +
                        "\t" + EditTrack.Text + "\t," +
                        "\tENDSMTAGS\t"; // use this to validate the clipboard data
            }
            catch { }
            return sOut;
        }
        //---------------------------------------------------------------------------
    }

    public class FileAbstraction : TagLib.File.IFileAbstraction
    {
        public FileAbstraction(string file)
        {
            Name = file;
        }
        public string Name { get; }
        public Stream ReadStream => MakeStream(Name);
        public Stream WriteStream => MakeStream(Name);
        private FileStream MakeStream(string name)
        {
            try
            {
                return new FileStream(name, FileMode.Open);
            }
            catch
            {
                return null;
            }
        }
        public void CloseStream(Stream stream)
        {
            stream.Close();
        }
    }
}
