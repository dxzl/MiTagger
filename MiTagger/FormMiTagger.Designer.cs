﻿namespace MiTagger
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiTagger));
            this.LabelPath = new System.Windows.Forms.Label();
            this.LabelCredit = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxClearPreExistingTags = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonPasteTags = new System.Windows.Forms.Button();
            this.ButtonCopyTags = new System.Windows.Forms.Button();
            this.LabelTrack = new System.Windows.Forms.Label();
            this.EditTrack = new System.Windows.Forms.TextBox();
            this.LabelYear = new System.Windows.Forms.Label();
            this.EditYear = new System.Windows.Forms.TextBox();
            this.LabelGenre = new System.Windows.Forms.Label();
            this.EditGenres = new System.Windows.Forms.TextBox();
            this.LabelArtist = new System.Windows.Forms.Label();
            this.EditArtists = new System.Windows.Forms.TextBox();
            this.LabelAlbum = new System.Windows.Forms.Label();
            this.EditAlbum = new System.Windows.Forms.TextBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.EditTitle = new System.Windows.Forms.TextBox();
            this.ListBoxInfo = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelPath
            // 
            this.LabelPath.AutoSize = true;
            this.LabelPath.Location = new System.Drawing.Point(-1, 266);
            this.LabelPath.Name = "LabelPath";
            this.LabelPath.Size = new System.Drawing.Size(32, 13);
            this.LabelPath.TabIndex = 1;
            this.LabelPath.Text = "Path:";
            // 
            // LabelCredit
            // 
            this.LabelCredit.AutoSize = true;
            this.LabelCredit.Location = new System.Drawing.Point(-1, 288);
            this.LabelCredit.Name = "LabelCredit";
            this.LabelCredit.Size = new System.Drawing.Size(37, 13);
            this.LabelCredit.TabIndex = 2;
            this.LabelCredit.Text = "Credit:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxClearPreExistingTags);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ButtonPasteTags);
            this.groupBox1.Controls.Add(this.ButtonCopyTags);
            this.groupBox1.Controls.Add(this.LabelTrack);
            this.groupBox1.Controls.Add(this.EditTrack);
            this.groupBox1.Controls.Add(this.LabelYear);
            this.groupBox1.Controls.Add(this.EditYear);
            this.groupBox1.Controls.Add(this.LabelGenre);
            this.groupBox1.Controls.Add(this.EditGenres);
            this.groupBox1.Controls.Add(this.LabelArtist);
            this.groupBox1.Controls.Add(this.EditArtists);
            this.groupBox1.Controls.Add(this.LabelAlbum);
            this.groupBox1.Controls.Add(this.EditAlbum);
            this.groupBox1.Controls.Add(this.LabelTitle);
            this.groupBox1.Controls.Add(this.EditTitle);
            this.groupBox1.Controls.Add(this.ListBoxInfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 227);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // checkBoxClearPreExistingTags
            // 
            this.checkBoxClearPreExistingTags.AutoSize = true;
            this.checkBoxClearPreExistingTags.Location = new System.Drawing.Point(65, 175);
            this.checkBoxClearPreExistingTags.Name = "checkBoxClearPreExistingTags";
            this.checkBoxClearPreExistingTags.Size = new System.Drawing.Size(227, 17);
            this.checkBoxClearPreExistingTags.TabIndex = 17;
            this.checkBoxClearPreExistingTags.Text = "Clear pre-existing tags on Save or Save As";
            this.toolTip1.SetToolTip(this.checkBoxClearPreExistingTags, "Check this to erase other tags that are not displayed by MiTagger");
            this.checkBoxClearPreExistingTags.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "*Tip: You can drag-drop multiple song files onto MiTagger to open all of them!";
            // 
            // ButtonPasteTags
            // 
            this.ButtonPasteTags.Location = new System.Drawing.Point(467, 149);
            this.ButtonPasteTags.Name = "ButtonPasteTags";
            this.ButtonPasteTags.Size = new System.Drawing.Size(75, 23);
            this.ButtonPasteTags.TabIndex = 15;
            this.ButtonPasteTags.Text = "Paste Tags";
            this.ButtonPasteTags.UseVisualStyleBackColor = true;
            this.ButtonPasteTags.Click += new System.EventHandler(this.ButtonPasteTags_Click);
            // 
            // ButtonCopyTags
            // 
            this.ButtonCopyTags.Location = new System.Drawing.Point(368, 149);
            this.ButtonCopyTags.Name = "ButtonCopyTags";
            this.ButtonCopyTags.Size = new System.Drawing.Size(75, 23);
            this.ButtonCopyTags.TabIndex = 14;
            this.ButtonCopyTags.Text = "Copy Tags";
            this.ButtonCopyTags.UseVisualStyleBackColor = true;
            this.ButtonCopyTags.Click += new System.EventHandler(this.ButtonCopyTags_Click);
            // 
            // LabelTrack
            // 
            this.LabelTrack.AutoSize = true;
            this.LabelTrack.Location = new System.Drawing.Point(182, 138);
            this.LabelTrack.Name = "LabelTrack";
            this.LabelTrack.Size = new System.Drawing.Size(35, 13);
            this.LabelTrack.TabIndex = 12;
            this.LabelTrack.Text = "Track";
            // 
            // EditTrack
            // 
            this.EditTrack.Location = new System.Drawing.Point(241, 135);
            this.EditTrack.Name = "EditTrack";
            this.EditTrack.Size = new System.Drawing.Size(90, 20);
            this.EditTrack.TabIndex = 11;
            // 
            // LabelYear
            // 
            this.LabelYear.AutoSize = true;
            this.LabelYear.Location = new System.Drawing.Point(6, 138);
            this.LabelYear.Name = "LabelYear";
            this.LabelYear.Size = new System.Drawing.Size(29, 13);
            this.LabelYear.TabIndex = 10;
            this.LabelYear.Text = "Year";
            // 
            // EditYear
            // 
            this.EditYear.Location = new System.Drawing.Point(65, 135);
            this.EditYear.Name = "EditYear";
            this.EditYear.Size = new System.Drawing.Size(83, 20);
            this.EditYear.TabIndex = 9;
            // 
            // LabelGenre
            // 
            this.LabelGenre.AutoSize = true;
            this.LabelGenre.Location = new System.Drawing.Point(6, 107);
            this.LabelGenre.Name = "LabelGenre";
            this.LabelGenre.Size = new System.Drawing.Size(47, 13);
            this.LabelGenre.TabIndex = 8;
            this.LabelGenre.Text = "Genre(s)";
            // 
            // EditGenres
            // 
            this.EditGenres.Location = new System.Drawing.Point(65, 104);
            this.EditGenres.Name = "EditGenres";
            this.EditGenres.Size = new System.Drawing.Size(266, 20);
            this.EditGenres.TabIndex = 7;
            this.toolTip1.SetToolTip(this.EditGenres, "Comma-separated list of genres");
            // 
            // LabelArtist
            // 
            this.LabelArtist.AutoSize = true;
            this.LabelArtist.Location = new System.Drawing.Point(6, 78);
            this.LabelArtist.Name = "LabelArtist";
            this.LabelArtist.Size = new System.Drawing.Size(41, 13);
            this.LabelArtist.TabIndex = 6;
            this.LabelArtist.Text = "Artist(s)";
            // 
            // EditArtists
            // 
            this.EditArtists.Location = new System.Drawing.Point(65, 75);
            this.EditArtists.Name = "EditArtists";
            this.EditArtists.Size = new System.Drawing.Size(266, 20);
            this.EditArtists.TabIndex = 5;
            this.toolTip1.SetToolTip(this.EditArtists, "Comma-separated list of artists");
            // 
            // LabelAlbum
            // 
            this.LabelAlbum.AutoSize = true;
            this.LabelAlbum.Location = new System.Drawing.Point(6, 50);
            this.LabelAlbum.Name = "LabelAlbum";
            this.LabelAlbum.Size = new System.Drawing.Size(36, 13);
            this.LabelAlbum.TabIndex = 4;
            this.LabelAlbum.Text = "Album";
            // 
            // EditAlbum
            // 
            this.EditAlbum.Location = new System.Drawing.Point(65, 47);
            this.EditAlbum.Name = "EditAlbum";
            this.EditAlbum.Size = new System.Drawing.Size(266, 20);
            this.EditAlbum.TabIndex = 3;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Location = new System.Drawing.Point(6, 22);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(27, 13);
            this.LabelTitle.TabIndex = 2;
            this.LabelTitle.Text = "Title";
            // 
            // EditTitle
            // 
            this.EditTitle.Location = new System.Drawing.Point(65, 19);
            this.EditTitle.Name = "EditTitle";
            this.EditTitle.Size = new System.Drawing.Size(266, 20);
            this.EditTitle.TabIndex = 1;
            // 
            // ListBoxInfo
            // 
            this.ListBoxInfo.FormattingEnabled = true;
            this.ListBoxInfo.Location = new System.Drawing.Point(349, 16);
            this.ListBoxInfo.Name = "ListBoxInfo";
            this.ListBoxInfo.Size = new System.Drawing.Size(208, 108);
            this.ListBoxInfo.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(587, 29);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.fIleToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(229, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.saveAsToolStripMenuItem.Text = "&Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 350;
            this.toolTip1.ReshowDelay = 100;
            // 
            // MiTagger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(587, 310);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LabelCredit);
            this.Controls.Add(this.LabelPath);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MiTagger";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MiTagger 1.07";
            this.Load += new System.EventHandler(this.MiTagger_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MiTagger_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MiTagger_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label LabelTitle;
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
    }
}

