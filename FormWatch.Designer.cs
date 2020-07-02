namespace ImdbFinal
{
    partial class FormWatch
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
            this.lblName = new System.Windows.Forms.Label();
            this.lstbxWatched = new System.Windows.Forms.ListBox();
            this.lblName1 = new System.Windows.Forms.Label();
            this.lstbxWatch = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(81, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(185, 29);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "My Watched List";
            // 
            // lstbxWatched
            // 
            this.lstbxWatched.FormattingEnabled = true;
            this.lstbxWatched.Location = new System.Drawing.Point(35, 63);
            this.lstbxWatched.Name = "lstbxWatched";
            this.lstbxWatched.Size = new System.Drawing.Size(279, 342);
            this.lstbxWatched.TabIndex = 9;
            this.lstbxWatched.SelectedIndexChanged += new System.EventHandler(this.LstbxWatched_SelectedIndexChanged);
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName1.Location = new System.Drawing.Point(406, 19);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(163, 29);
            this.lblName1.TabIndex = 12;
            this.lblName1.Text = "My Watch List";
            // 
            // lstbxWatch
            // 
            this.lstbxWatch.FormattingEnabled = true;
            this.lstbxWatch.Location = new System.Drawing.Point(349, 63);
            this.lstbxWatch.Name = "lstbxWatch";
            this.lstbxWatch.Size = new System.Drawing.Size(279, 342);
            this.lstbxWatch.TabIndex = 11;
            this.lstbxWatch.SelectedIndexChanged += new System.EventHandler(this.LstbxWatch_SelectedIndexChanged);
            // 
            // FormWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblName1);
            this.Controls.Add(this.lstbxWatch);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lstbxWatched);
            this.Name = "FormWatch";
            this.Text = "FormWatch";
            this.Load += new System.EventHandler(this.FormWatch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListBox lstbxWatched;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.ListBox lstbxWatch;
    }
}