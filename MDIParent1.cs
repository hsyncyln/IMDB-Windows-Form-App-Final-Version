using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImdbFinal
{
    public partial class MDIParent1 : Form
    {
        List<Movie> _listmovies { get; set; }
        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            FormMain childForm = new FormMain();
            childForm.MdiParent = this;
            childForm.Text = "Anasayfa ";
            childForm.Show();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            FormMain childForm = new FormMain();
            childForm.MdiParent = this;
            childForm.Text = "Imdb Search";
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Tag = progressBar1;
            childForm.Show();

        }

        private void ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void NewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormImage childForm = new FormImage();
            childForm.MdiParent = this;
            childForm.Tag = progressBar1;
            childForm.Text = "New User";
            childForm.Show();
        }
        private void StatusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }
        }

        private void WatchListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 5;
            FormWatch form = new FormWatch();
            form.MdiParent = this;
            form.Tag = progressBar1;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }
    }
}
