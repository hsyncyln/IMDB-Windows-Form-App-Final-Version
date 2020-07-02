namespace ImdbFinal
{
    partial class FormCast
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtbxBornInfo = new System.Windows.Forms.TextBox();
            this.rchbxDetail = new System.Windows.Forms.RichTextBox();
            this.lblBornInfo = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.lblShows = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnImages = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(112, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 148);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(344, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(237, 238);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // txtbxBornInfo
            // 
            this.txtbxBornInfo.Location = new System.Drawing.Point(66, 212);
            this.txtbxBornInfo.Name = "txtbxBornInfo";
            this.txtbxBornInfo.Size = new System.Drawing.Size(232, 20);
            this.txtbxBornInfo.TabIndex = 2;
            // 
            // rchbxDetail
            // 
            this.rchbxDetail.Location = new System.Drawing.Point(66, 251);
            this.rchbxDetail.Name = "rchbxDetail";
            this.rchbxDetail.Size = new System.Drawing.Size(232, 96);
            this.rchbxDetail.TabIndex = 3;
            this.rchbxDetail.Text = "";
            // 
            // lblBornInfo
            // 
            this.lblBornInfo.AutoSize = true;
            this.lblBornInfo.Location = new System.Drawing.Point(141, 196);
            this.lblBornInfo.Name = "lblBornInfo";
            this.lblBornInfo.Size = new System.Drawing.Size(84, 13);
            this.lblBornInfo.TabIndex = 4;
            this.lblBornInfo.Text = "Born Information";
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Location = new System.Drawing.Point(157, 235);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(34, 13);
            this.lblDetail.TabIndex = 5;
            this.lblDetail.Text = "Detail";
            // 
            // lblShows
            // 
            this.lblShows.AutoSize = true;
            this.lblShows.Location = new System.Drawing.Point(440, 54);
            this.lblShows.Name = "lblShows";
            this.lblShows.Size = new System.Drawing.Size(39, 13);
            this.lblShows.TabIndex = 6;
            this.lblShows.Text = "Shows";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(245, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(123, 29);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Cast Name";
            // 
            // btnImages
            // 
            this.btnImages.Location = new System.Drawing.Point(402, 314);
            this.btnImages.Name = "btnImages";
            this.btnImages.Size = new System.Drawing.Size(122, 23);
            this.btnImages.TabIndex = 8;
            this.btnImages.Text = "Show More Images";
            this.btnImages.UseVisualStyleBackColor = true;
            this.btnImages.Click += new System.EventHandler(this.BtnImages_Click);
            // 
            // FormCast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 372);
            this.Controls.Add(this.btnImages);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblShows);
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.lblBornInfo);
            this.Controls.Add(this.rchbxDetail);
            this.Controls.Add(this.txtbxBornInfo);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormCast";
            this.Text = "FormCast";
            this.Load += new System.EventHandler(this.FormCast_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtbxBornInfo;
        private System.Windows.Forms.RichTextBox rchbxDetail;
        private System.Windows.Forms.Label lblBornInfo;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Label lblShows;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnImages;
    }
}