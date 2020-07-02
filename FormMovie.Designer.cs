namespace ImdbFinal
{
    partial class FormMovie
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
            this.pbxPoster = new System.Windows.Forms.PictureBox();
            this.lstbxGenre = new System.Windows.Forms.ListBox();
            this.rchbxDescription = new System.Windows.Forms.RichTextBox();
            this.rchbxDate = new System.Windows.Forms.RichTextBox();
            this.rchbxRate = new System.Windows.Forms.RichTextBox();
            this.lstbxCast = new System.Windows.Forms.ListBox();
            this.rchbxRole = new System.Windows.Forms.RichTextBox();
            this.btnPictures = new System.Windows.Forms.Button();
            this.rchbxMyRate = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblMyRate = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblCast = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.checkbxWatch = new System.Windows.Forms.CheckBox();
            this.checkbxWatched = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxPoster
            // 
            this.pbxPoster.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxPoster.Location = new System.Drawing.Point(34, 35);
            this.pbxPoster.Name = "pbxPoster";
            this.pbxPoster.Size = new System.Drawing.Size(172, 207);
            this.pbxPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPoster.TabIndex = 0;
            this.pbxPoster.TabStop = false;
            // 
            // lstbxGenre
            // 
            this.lstbxGenre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstbxGenre.FormattingEnabled = true;
            this.lstbxGenre.Location = new System.Drawing.Point(34, 310);
            this.lstbxGenre.Name = "lstbxGenre";
            this.lstbxGenre.Size = new System.Drawing.Size(172, 108);
            this.lstbxGenre.TabIndex = 4;
            this.lstbxGenre.SelectedIndexChanged += new System.EventHandler(this.LstbxGenre_SelectedIndexChanged);
            // 
            // rchbxDescription
            // 
            this.rchbxDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rchbxDescription.Location = new System.Drawing.Point(248, 294);
            this.rchbxDescription.Name = "rchbxDescription";
            this.rchbxDescription.Size = new System.Drawing.Size(353, 100);
            this.rchbxDescription.TabIndex = 5;
            this.rchbxDescription.Text = "";
            // 
            // rchbxDate
            // 
            this.rchbxDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rchbxDate.Location = new System.Drawing.Point(93, 268);
            this.rchbxDate.Name = "rchbxDate";
            this.rchbxDate.Size = new System.Drawing.Size(113, 23);
            this.rchbxDate.TabIndex = 6;
            this.rchbxDate.Text = "";
            // 
            // rchbxRate
            // 
            this.rchbxRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rchbxRate.Location = new System.Drawing.Point(34, 268);
            this.rchbxRate.Name = "rchbxRate";
            this.rchbxRate.Size = new System.Drawing.Size(53, 23);
            this.rchbxRate.TabIndex = 7;
            this.rchbxRate.Text = "";
            // 
            // lstbxCast
            // 
            this.lstbxCast.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstbxCast.FormattingEnabled = true;
            this.lstbxCast.Location = new System.Drawing.Point(372, 105);
            this.lstbxCast.Name = "lstbxCast";
            this.lstbxCast.Size = new System.Drawing.Size(224, 160);
            this.lstbxCast.TabIndex = 8;
            this.lstbxCast.SelectedIndexChanged += new System.EventHandler(this.LstbxCast_SelectedIndexChanged);
            // 
            // rchbxRole
            // 
            this.rchbxRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rchbxRole.Location = new System.Drawing.Point(248, 107);
            this.rchbxRole.Name = "rchbxRole";
            this.rchbxRole.Size = new System.Drawing.Size(111, 160);
            this.rchbxRole.TabIndex = 9;
            this.rchbxRole.Text = "";
            // 
            // btnPictures
            // 
            this.btnPictures.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPictures.Location = new System.Drawing.Point(389, 400);
            this.btnPictures.Name = "btnPictures";
            this.btnPictures.Size = new System.Drawing.Size(103, 27);
            this.btnPictures.TabIndex = 10;
            this.btnPictures.Text = "Show Images";
            this.btnPictures.UseVisualStyleBackColor = true;
            this.btnPictures.Click += new System.EventHandler(this.Button1_Click);
            // 
            // rchbxMyRate
            // 
            this.rchbxMyRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rchbxMyRate.Location = new System.Drawing.Point(389, 51);
            this.rchbxMyRate.Name = "rchbxMyRate";
            this.rchbxMyRate.Size = new System.Drawing.Size(98, 25);
            this.rchbxMyRate.TabIndex = 11;
            this.rchbxMyRate.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Location = new System.Drawing.Point(510, 51);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblRate
            // 
            this.lblRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(46, 252);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(30, 13);
            this.lblRate.TabIndex = 13;
            this.lblRate.Text = "Rate";
            // 
            // lblMyRate
            // 
            this.lblMyRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMyRate.AutoSize = true;
            this.lblMyRate.Location = new System.Drawing.Point(403, 33);
            this.lblMyRate.Name = "lblMyRate";
            this.lblMyRate.Size = new System.Drawing.Size(47, 13);
            this.lblMyRate.TabIndex = 14;
            this.lblMyRate.Text = "My Rate";
            // 
            // lblRole
            // 
            this.lblRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(284, 91);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(34, 13);
            this.lblRole.TabIndex = 15;
            this.lblRole.Text = "Roles";
            // 
            // lblCast
            // 
            this.lblCast.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCast.AutoSize = true;
            this.lblCast.Location = new System.Drawing.Point(405, 91);
            this.lblCast.Name = "lblCast";
            this.lblCast.Size = new System.Drawing.Size(28, 13);
            this.lblCast.TabIndex = 16;
            this.lblCast.Text = "Cast";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(111, 252);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(81, 13);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "Publishing Date";
            // 
            // lblGenre
            // 
            this.lblGenre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(98, 294);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(41, 13);
            this.lblGenre.TabIndex = 18;
            this.lblGenre.Text = "Genres";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(356, 278);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 19;
            this.lblDescription.Text = "Description";
            // 
            // checkbxWatch
            // 
            this.checkbxWatch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkbxWatch.AutoSize = true;
            this.checkbxWatch.Location = new System.Drawing.Point(248, 35);
            this.checkbxWatch.Name = "checkbxWatch";
            this.checkbxWatch.Size = new System.Drawing.Size(111, 17);
            this.checkbxWatch.TabIndex = 20;
            this.checkbxWatch.Text = "Add to Watch List";
            this.checkbxWatch.UseVisualStyleBackColor = true;
            this.checkbxWatch.CheckedChanged += new System.EventHandler(this.CheckbxWatch_CheckedChanged);
            // 
            // checkbxWatched
            // 
            this.checkbxWatched.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkbxWatched.AutoSize = true;
            this.checkbxWatched.Location = new System.Drawing.Point(248, 59);
            this.checkbxWatched.Name = "checkbxWatched";
            this.checkbxWatched.Size = new System.Drawing.Size(124, 17);
            this.checkbxWatched.TabIndex = 21;
            this.checkbxWatched.Text = "Add to Watched Lİst";
            this.checkbxWatched.UseVisualStyleBackColor = true;
            this.checkbxWatched.CheckedChanged += new System.EventHandler(this.CheckbxFavorite_CheckedChanged);
            // 
            // FormMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(652, 440);
            this.Controls.Add(this.checkbxWatched);
            this.Controls.Add(this.checkbxWatch);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCast);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblMyRate);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rchbxMyRate);
            this.Controls.Add(this.btnPictures);
            this.Controls.Add(this.rchbxRole);
            this.Controls.Add(this.lstbxCast);
            this.Controls.Add(this.rchbxRate);
            this.Controls.Add(this.rchbxDate);
            this.Controls.Add(this.rchbxDescription);
            this.Controls.Add(this.lstbxGenre);
            this.Controls.Add(this.pbxPoster);
            this.Name = "FormMovie";
            this.Text = "FormMovie";
            this.Load += new System.EventHandler(this.FormMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxPoster;
        private System.Windows.Forms.ListBox lstbxGenre;
        private System.Windows.Forms.RichTextBox rchbxDescription;
        private System.Windows.Forms.RichTextBox rchbxDate;
        private System.Windows.Forms.RichTextBox rchbxRate;
        private System.Windows.Forms.ListBox lstbxCast;
        private System.Windows.Forms.RichTextBox rchbxRole;
        private System.Windows.Forms.Button btnPictures;
        private System.Windows.Forms.RichTextBox rchbxMyRate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblMyRate;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblCast;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.CheckBox checkbxWatch;
        private System.Windows.Forms.CheckBox checkbxWatched;
    }
}