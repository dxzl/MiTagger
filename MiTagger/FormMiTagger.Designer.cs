namespace MiTagger
{
    partial class MiTagger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiTagger));
            LabelPath = new System.Windows.Forms.Label();
            LabelCredit = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            ButtonExit = new System.Windows.Forms.Button();
            LabelComment = new System.Windows.Forms.Label();
            EditComment = new System.Windows.Forms.TextBox();
            ButtonSave = new System.Windows.Forms.Button();
            checkBoxClearPreExistingTags = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            ButtonPasteTags = new System.Windows.Forms.Button();
            ButtonCopyTags = new System.Windows.Forms.Button();
            LabelTrack = new System.Windows.Forms.Label();
            EditTrack = new System.Windows.Forms.TextBox();
            LabelYear = new System.Windows.Forms.Label();
            EditYear = new System.Windows.Forms.TextBox();
            LabelGenre = new System.Windows.Forms.Label();
            EditGenres = new System.Windows.Forms.TextBox();
            LabelArtist = new System.Windows.Forms.Label();
            EditArtists = new System.Windows.Forms.TextBox();
            LabelAlbum = new System.Windows.Forms.Label();
            EditAlbum = new System.Windows.Forms.TextBox();
            LabelTitle = new System.Windows.Forms.Label();
            EditTitle = new System.Windows.Forms.TextBox();
            ListBoxInfo = new System.Windows.Forms.ListBox();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            copyTagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pasteTagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            timerMiMessage = new System.Windows.Forms.Timer(components);
            timerCheckClipboard = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // LabelPath
            // 
            LabelPath.AutoSize = true;
            LabelPath.Location = new System.Drawing.Point(-1, 370);
            LabelPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LabelPath.Name = "LabelPath";
            LabelPath.Size = new System.Drawing.Size(34, 15);
            LabelPath.TabIndex = 1;
            LabelPath.Text = "Path:";
            // 
            // LabelCredit
            // 
            LabelCredit.AutoSize = true;
            LabelCredit.Location = new System.Drawing.Point(-1, 397);
            LabelCredit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LabelCredit.Name = "LabelCredit";
            LabelCredit.Size = new System.Drawing.Size(42, 15);
            LabelCredit.TabIndex = 2;
            LabelCredit.Text = "Credit:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ButtonExit);
            groupBox1.Controls.Add(LabelComment);
            groupBox1.Controls.Add(EditComment);
            groupBox1.Controls.Add(ButtonSave);
            groupBox1.Controls.Add(checkBoxClearPreExistingTags);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ButtonPasteTags);
            groupBox1.Controls.Add(ButtonCopyTags);
            groupBox1.Controls.Add(LabelTrack);
            groupBox1.Controls.Add(EditTrack);
            groupBox1.Controls.Add(LabelYear);
            groupBox1.Controls.Add(EditYear);
            groupBox1.Controls.Add(LabelGenre);
            groupBox1.Controls.Add(EditGenres);
            groupBox1.Controls.Add(LabelArtist);
            groupBox1.Controls.Add(EditArtists);
            groupBox1.Controls.Add(LabelAlbum);
            groupBox1.Controls.Add(EditAlbum);
            groupBox1.Controls.Add(LabelTitle);
            groupBox1.Controls.Add(EditTitle);
            groupBox1.Controls.Add(ListBoxInfo);
            groupBox1.Location = new System.Drawing.Point(2, 30);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(682, 337);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // ButtonExit
            // 
            ButtonExit.Location = new System.Drawing.Point(562, 286);
            ButtonExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ButtonExit.Name = "ButtonExit";
            ButtonExit.Size = new System.Drawing.Size(88, 27);
            ButtonExit.TabIndex = 11;
            ButtonExit.Text = "Exit";
            ButtonExit.UseVisualStyleBackColor = true;
            ButtonExit.Click += ButtonClose_Click;
            // 
            // LabelComment
            // 
            LabelComment.AutoSize = true;
            LabelComment.Location = new System.Drawing.Point(7, 160);
            LabelComment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LabelComment.Name = "LabelComment";
            LabelComment.Size = new System.Drawing.Size(61, 15);
            LabelComment.TabIndex = 0;
            LabelComment.Text = "Comment";
            // 
            // EditComment
            // 
            EditComment.AcceptsReturn = true;
            EditComment.Location = new System.Drawing.Point(76, 157);
            EditComment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            EditComment.Multiline = true;
            EditComment.Name = "EditComment";
            EditComment.Size = new System.Drawing.Size(310, 65);
            EditComment.TabIndex = 5;
            toolTip1.SetToolTip(EditComment, "Comma-separated list of genres");
            // 
            // ButtonSave
            // 
            ButtonSave.Enabled = false;
            ButtonSave.Location = new System.Drawing.Point(451, 286);
            ButtonSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new System.Drawing.Size(88, 27);
            ButtonSave.TabIndex = 10;
            ButtonSave.Text = "Save";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // checkBoxClearPreExistingTags
            // 
            checkBoxClearPreExistingTags.AutoSize = true;
            checkBoxClearPreExistingTags.Location = new System.Drawing.Point(63, 286);
            checkBoxClearPreExistingTags.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxClearPreExistingTags.Name = "checkBoxClearPreExistingTags";
            checkBoxClearPreExistingTags.Size = new System.Drawing.Size(244, 19);
            checkBoxClearPreExistingTags.TabIndex = 17;
            checkBoxClearPreExistingTags.Text = "Clear pre-existing tags on Save or Save As";
            toolTip1.SetToolTip(checkBoxClearPreExistingTags, "Check this to erase other tags that are not displayed by MiTagger");
            checkBoxClearPreExistingTags.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(-4, 318);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(422, 15);
            label1.TabIndex = 16;
            label1.Text = "*Tip: You can drag-drop multiple song files onto MiTagger to open all of them!";
            // 
            // ButtonPasteTags
            // 
            ButtonPasteTags.Enabled = false;
            ButtonPasteTags.Location = new System.Drawing.Point(562, 238);
            ButtonPasteTags.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ButtonPasteTags.Name = "ButtonPasteTags";
            ButtonPasteTags.Size = new System.Drawing.Size(88, 27);
            ButtonPasteTags.TabIndex = 9;
            ButtonPasteTags.Text = "Paste Tags";
            ButtonPasteTags.UseVisualStyleBackColor = true;
            ButtonPasteTags.Click += ButtonPasteTags_Click;
            // 
            // ButtonCopyTags
            // 
            ButtonCopyTags.Location = new System.Drawing.Point(451, 238);
            ButtonCopyTags.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ButtonCopyTags.Name = "ButtonCopyTags";
            ButtonCopyTags.Size = new System.Drawing.Size(88, 27);
            ButtonCopyTags.TabIndex = 8;
            ButtonCopyTags.Text = "Copy Tags";
            ButtonCopyTags.UseVisualStyleBackColor = true;
            ButtonCopyTags.Click += ButtonCopyTags_Click;
            // 
            // LabelTrack
            // 
            LabelTrack.AutoSize = true;
            LabelTrack.Location = new System.Drawing.Point(180, 238);
            LabelTrack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LabelTrack.Name = "LabelTrack";
            LabelTrack.Size = new System.Drawing.Size(35, 15);
            LabelTrack.TabIndex = 0;
            LabelTrack.Text = "Track";
            // 
            // EditTrack
            // 
            EditTrack.Location = new System.Drawing.Point(227, 234);
            EditTrack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            EditTrack.Name = "EditTrack";
            EditTrack.Size = new System.Drawing.Size(83, 23);
            EditTrack.TabIndex = 7;
            // 
            // LabelYear
            // 
            LabelYear.AutoSize = true;
            LabelYear.Location = new System.Drawing.Point(21, 238);
            LabelYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LabelYear.Name = "LabelYear";
            LabelYear.Size = new System.Drawing.Size(29, 15);
            LabelYear.TabIndex = 0;
            LabelYear.Text = "Year";
            // 
            // EditYear
            // 
            EditYear.Location = new System.Drawing.Point(76, 234);
            EditYear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            EditYear.Name = "EditYear";
            EditYear.Size = new System.Drawing.Size(83, 23);
            EditYear.TabIndex = 6;
            // 
            // LabelGenre
            // 
            LabelGenre.AutoSize = true;
            LabelGenre.Location = new System.Drawing.Point(7, 123);
            LabelGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LabelGenre.Name = "LabelGenre";
            LabelGenre.Size = new System.Drawing.Size(51, 15);
            LabelGenre.TabIndex = 0;
            LabelGenre.Text = "Genre(s)";
            // 
            // EditGenres
            // 
            EditGenres.Location = new System.Drawing.Point(76, 120);
            EditGenres.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            EditGenres.Name = "EditGenres";
            EditGenres.Size = new System.Drawing.Size(310, 23);
            EditGenres.TabIndex = 4;
            toolTip1.SetToolTip(EditGenres, "Comma-separated list of genres");
            // 
            // LabelArtist
            // 
            LabelArtist.AutoSize = true;
            LabelArtist.Location = new System.Drawing.Point(7, 90);
            LabelArtist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LabelArtist.Name = "LabelArtist";
            LabelArtist.Size = new System.Drawing.Size(48, 15);
            LabelArtist.TabIndex = 0;
            LabelArtist.Text = "Artist(s)";
            // 
            // EditArtists
            // 
            EditArtists.Location = new System.Drawing.Point(76, 87);
            EditArtists.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            EditArtists.Name = "EditArtists";
            EditArtists.Size = new System.Drawing.Size(310, 23);
            EditArtists.TabIndex = 3;
            toolTip1.SetToolTip(EditArtists, "Comma-separated list of artists");
            // 
            // LabelAlbum
            // 
            LabelAlbum.AutoSize = true;
            LabelAlbum.Location = new System.Drawing.Point(7, 58);
            LabelAlbum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LabelAlbum.Name = "LabelAlbum";
            LabelAlbum.Size = new System.Drawing.Size(43, 15);
            LabelAlbum.TabIndex = 0;
            LabelAlbum.Text = "Album";
            // 
            // EditAlbum
            // 
            EditAlbum.Location = new System.Drawing.Point(76, 54);
            EditAlbum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            EditAlbum.Name = "EditAlbum";
            EditAlbum.Size = new System.Drawing.Size(310, 23);
            EditAlbum.TabIndex = 2;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Location = new System.Drawing.Point(7, 25);
            LabelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new System.Drawing.Size(30, 15);
            LabelTitle.TabIndex = 0;
            LabelTitle.Text = "Title";
            // 
            // EditTitle
            // 
            EditTitle.Location = new System.Drawing.Point(76, 22);
            EditTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            EditTitle.Name = "EditTitle";
            EditTitle.Size = new System.Drawing.Size(310, 23);
            EditTitle.TabIndex = 1;
            // 
            // ListBoxInfo
            // 
            ListBoxInfo.FormattingEnabled = true;
            ListBoxInfo.ItemHeight = 15;
            ListBoxInfo.Location = new System.Drawing.Point(407, 25);
            ListBoxInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ListBoxInfo.Name = "ListBoxInfo";
            ListBoxInfo.Size = new System.Drawing.Size(261, 199);
            ListBoxInfo.TabIndex = 12;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fIleToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(685, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { openToolStripMenuItem, toolStripMenuItem1, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripMenuItem2, exitToolStripMenuItem });
            fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fIleToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
            openToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(183, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
            saveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.S;
            saveAsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            saveAsToolStripMenuItem.Text = "&Save As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(183, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q;
            exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            exitToolStripMenuItem.Text = "&Exit";
            exitToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { copyTagsToolStripMenuItem, pasteTagsToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // copyTagsToolStripMenuItem
            // 
            copyTagsToolStripMenuItem.Name = "copyTagsToolStripMenuItem";
            copyTagsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C;
            copyTagsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            copyTagsToolStripMenuItem.Text = "Copy Tags";
            copyTagsToolStripMenuItem.Click += copyTagsToolStripMenuItem_Click;
            // 
            // pasteTagsToolStripMenuItem
            // 
            pasteTagsToolStripMenuItem.Name = "pasteTagsToolStripMenuItem";
            pasteTagsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V;
            pasteTagsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            pasteTagsToolStripMenuItem.Text = "Paste Tags";
            pasteTagsToolStripMenuItem.Click += pasteTagsToolStripMenuItem_Click;
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 350;
            toolTip1.ReshowDelay = 100;
            // 
            // timerMiMessage
            // 
            timerMiMessage.Interval = 7000;
            timerMiMessage.Tick += TimerMiMessage_Tick;
            // 
            // timerCheckClipboard
            // 
            timerCheckClipboard.Interval = 2000;
            timerCheckClipboard.Tick += timerCheckClipboard_Tick;
            // 
            // MiTagger
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(685, 422);
            Controls.Add(groupBox1);
            Controls.Add(LabelCredit);
            Controls.Add(LabelPath);
            Controls.Add(menuStrip1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "MiTagger";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            Text = "MiTagger 1.11";
            Load += MiTagger_Load;
            DragDrop += MiTagger_DragDrop;
            DragEnter += MiTagger_DragEnter;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelPath;
        private System.Windows.Forms.Label LabelCredit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonPasteTags;
        private System.Windows.Forms.Button ButtonCopyTags;
        private System.Windows.Forms.Label LabelTrack;
        private System.Windows.Forms.TextBox EditTrack;
        private System.Windows.Forms.Label LabelYear;
        private System.Windows.Forms.TextBox EditYear;
        private System.Windows.Forms.Label LabelGenre;
        private System.Windows.Forms.TextBox EditGenres;
        private System.Windows.Forms.Label LabelArtist;
        private System.Windows.Forms.TextBox EditArtists;
        private System.Windows.Forms.Label LabelAlbum;
        private System.Windows.Forms.TextBox EditAlbum;
        private System.Windows.Forms.TextBox EditTitle;
        private System.Windows.Forms.ListBox ListBoxInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxClearPreExistingTags;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyTagsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteTagsToolStripMenuItem;
        private System.Windows.Forms.Timer timerMiMessage;
        private System.Windows.Forms.Label LabelComment;
        private System.Windows.Forms.TextBox EditComment;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer timerCheckClipboard;
    }
}

