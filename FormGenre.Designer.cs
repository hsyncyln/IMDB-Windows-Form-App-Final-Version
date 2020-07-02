namespace ImdbFinal
{
    partial class FormGenre
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
            this.lstbxGenreMovies = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbxGenreMovies
            // 
            this.lstbxGenreMovies.FormattingEnabled = true;
            this.lstbxGenreMovies.Location = new System.Drawing.Point(182, 53);
            this.lstbxGenreMovies.Name = "lstbxGenreMovies";
            this.lstbxGenreMovies.Size = new System.Drawing.Size(331, 368);
            this.lstbxGenreMovies.TabIndex = 0;
            this.lstbxGenreMovies.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(255, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(132, 29);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Genre Name";
            // 
            // FormGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lstbxGenreMovies);
            this.Name = "FormGenre";
            this.Text = "FormGenre";
            this.Load += new System.EventHandler(this.FormGenre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxGenreMovies;
        private System.Windows.Forms.Label lblName;
    }
}