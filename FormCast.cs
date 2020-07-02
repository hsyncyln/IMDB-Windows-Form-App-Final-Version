using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImdbFinal
{
    public partial class FormCast : Form
    {
        public Cast _Cast { get; set; }
        public FormCast()
        {
            InitializeComponent();
        }

        private void FormCast_Load(object sender, EventArgs e)
        {
            (this.Tag as ProgressBar).Value = 50;
            this.WindowState = FormWindowState.Maximized;

            lblName.Text = _Cast.FirstName + " " + _Cast.LastName;
            txtbxBornInfo.Text = _Cast.BirthDate.ToString();
            rchbxDetail.Text = _Cast.Description;

            (this.Tag as ProgressBar).Value =65;
            _Cast.CastShows();
            (this.Tag as ProgressBar).Value = 85;
            foreach (Movie movie in _Cast.Shows)
            {
                listBox1.Items.Add(movie);
            }
            (this.Tag as ProgressBar).Value = 100;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProgressBar pro = (ProgressBar)this.Tag;
            pro.Value = 5;
            Movie movie = (Movie)listBox1.SelectedItem;
            DbMethods.DbHasMovie(movie);
            pro.Value = 20;
            FormMovie form = new FormMovie();
            form.MdiParent = this.MdiParent;
            form._Movie = movie;
            form.Tag = pro;
            form.Show();
        }

        private void BtnImages_Click(object sender, EventArgs e)
        {
            ProgressBar pro = (ProgressBar)this.Tag;
            pro.Value = 5;
            FormImage form = new FormImage();
            form.MdiParent = this.MdiParent;
            form.Tag = this.Tag;
            form._Cast =_Cast;
            form.WindowState = FormWindowState.Maximized;
            form.Show();

        }
    }
}
