namespace ImdbFinal
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.txtbx = new System.Windows.Forms.TextBox();
            this.pbxSearch = new System.Windows.Forms.PictureBox();
            this.cmbbxSearch = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panelSearch);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 398);
            this.panel1.TabIndex = 3;
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearch.BackColor = System.Drawing.Color.Transparent;
            this.panelSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelSearch.BackgroundImage")));
            this.panelSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSearch.Controls.Add(this.txtbx);
            this.panelSearch.Controls.Add(this.pbxSearch);
            this.panelSearch.Controls.Add(this.cmbbxSearch);
            this.panelSearch.Location = new System.Drawing.Point(148, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(412, 292);
            this.panelSearch.TabIndex = 0;
            // 
            // txtbx
            // 
            this.txtbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbx.Location = new System.Drawing.Point(71, 140);
            this.txtbx.Name = "txtbx";
            this.txtbx.Size = new System.Drawing.Size(197, 20);
            this.txtbx.TabIndex = 5;
            // 
            // pbxSearch
            // 
            this.pbxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxSearch.BackgroundImage")));
            this.pbxSearch.Location = new System.Drawing.Point(303, 135);
            this.pbxSearch.Name = "pbxSearch";
            this.pbxSearch.Size = new System.Drawing.Size(40, 32);
            this.pbxSearch.TabIndex = 10;
            this.pbxSearch.TabStop = false;
            this.pbxSearch.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // cmbbxSearch
            // 
            this.cmbbxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbbxSearch.FormattingEnabled = true;
            this.cmbbxSearch.Location = new System.Drawing.Point(71, 140);
            this.cmbbxSearch.Name = "cmbbxSearch";
            this.cmbbxSearch.Size = new System.Drawing.Size(216, 21);
            this.cmbbxSearch.TabIndex = 1;
            this.cmbbxSearch.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(709, 393);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormMain";
            this.panel1.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbx;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.PictureBox pbxSearch;
        private System.Windows.Forms.ComboBox cmbbxSearch;
    }
}