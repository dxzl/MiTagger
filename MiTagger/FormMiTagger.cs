using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaTags;

namespace MiTagger
{
    public partial class MiTagger : Form
    {
        const int TOKENCOUNT = 7;

        SongInfo si = null;
        string m_filePath = "";

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

            LabelCredit.Text = "Credits: Thanks to the taglib-sharp coding team and Tim Sneith's MediaCatalog project.";

            string[] arguments = Environment.GetCommandLineArgs();
            // NOTE: arguement[0] has the exe file name
            if (arguments.Length == 2)
            {
                if (System.IO.File.Exists(arguments[1]))
                    DoTags(arguments[1]);
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
                DoTags(FileList[0]);
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
        private void ButtonSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (si != null && m_filePath != "")
                {
                    using (var tags = new MediaTags.MediaTags())
                    {
                        si = tags.Read(m_filePath);
                        if (si != null)
                        {
                            var tagsCount = 0;
                            if (si.Title != EditTitle.Text)
                            {
                                si.Title = EditTitle.Text;
                                si.bTitleTag = true;
                                tagsCount++;
                            }
                            if (si.Album != EditAlbum.Text)
                            {
                                si.Album = EditAlbum.Text;
                                si.bAlbumTag = true;
                                tagsCount++;
                            }
                            if (si.Artist != EditArtist.Text)
                            {
                                si.Artist = EditArtist.Text;
                                si.bArtistTag = true;
                                tagsCount++;
                            }
                            if (si.Genre != EditGenre.Text)
                            {
                                si.Genre = EditGenre.Text;
                                si.bGenreTag = true;
                                tagsCount++;
                            }
                            if (si.Year != EditYear.Text)
                            {
                                si.Year = EditYear.Text;
                                si.bYearTag = true;
                                tagsCount++;
                            }
                            if (si.Track != EditTrack.Text)
                            {
                                si.Track = EditTrack.Text;
                                si.bTrackTag = true;
                                tagsCount++;
                            }
                            tags.Write(si, m_filePath);
                            MessageBox.Show("Wrote " + tagsCount + " tags to \"" + m_filePath + "\"");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Unable to write tags to: \"" + m_filePath + "\"");
            }
        }
        //---------------------------------------------------------------------------
        private string GetFileType(int fileType)
        {
            switch (fileType) {
                case 0:
                    return "WMA";
                case 1:
                    return "MP3";
                default:
                    return "unknown";
            };
        }
        //---------------------------------------------------------------------------
        private void fIleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    DoTags(openFileDialog.FileName);
            }
        }
        //---------------------------------------------------------------------------
        private void DoTags(String filePath)
        {
            using (var tagReader = new MediaTags.MediaTags())
            {
                m_filePath = filePath;
                if ((si = tagReader.Read(m_filePath)) != null)
                {
                    if (si.bException)
                      MessageBox.Show("Read fault... please retry!");
                    else
                    {
                      EditTitle.Text = StripTab(si.Title);
                      EditAlbum.Text = StripTab(si.Album);
                      EditArtist.Text = StripTab(si.Artist);
                      EditGenre.Text = StripTab(si.Genre);
                      EditYear.Text = StripTab(si.Year);
                      EditTrack.Text = StripTab(si.Track);
                      LabelPath.Text = m_filePath;
                      ListBoxInfo.Items.Clear();
                      if (si.BitRate >= 0)
                          ListBoxInfo.Items.Add("Bit rate:\t" + si.BitRate);
                      if (si.SampleRate >= 0)
                        ListBoxInfo.Items.Add("Sample rate:\t" + si.SampleRate);
                      if (si.Channels >= 0)
                          ListBoxInfo.Items.Add("Channels:\t " + si.Channels);
                      if (si.FileType >= 0)
                          ListBoxInfo.Items.Add("File type:\t" + GetFileType(si.FileType));
                      if (si.FileSize >= 0)
                          ListBoxInfo.Items.Add("File size:\t" + si.FileSize);
                      if (si.Duration != null)
                          ListBoxInfo.Items.Add("Duration:\t" + si.Duration);
                    }
                }
            }
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
                EditArtist.Text = StripTab(sl[5]);
                EditAlbum.Text = StripTab(sl[4]);
                EditGenre.Text = StripTab(sl[3]);
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
                        "\t" + EditArtist.Text + "\t," +
                        "\t" + EditAlbum.Text + "\t," +
                        "\t" + EditGenre.Text + "\t," +
                        "\t" + EditYear.Text + "\t," +
                        "\t" + EditTrack.Text + "\t," +
                        "\tENDSMTAGS\t"; // use this to validate the clipboard data
            }
            catch { }
            return sOut;
        }
        //---------------------------------------------------------------------------
    }
}
