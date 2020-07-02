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
    public partial class FormWatch : Form
    {
        public Movie _Movie { get; set; }
        public FormWatch()
        {
            InitializeComponent();
        }

        private void FormWatch_Load(object sender, EventArgs e)
        {
            (this.Tag as ProgressBar).Value = 40;
            List<Movie> list=DbMethods.DbFindMovieWatch(1);

            foreach(Movie movie in list)
            {
                lstbxWatched.Items.Add(movie);
            }

            (this.Tag as ProgressBar).Value = 70;
            list = DbMethods.DbFindMovieWatch(0);

            foreach (Movie movie in list)
            {
                lstbxWatch.Items.Add(movie);
            }
            (this.Tag as ProgressBar).Value = 100;
        }

        private void LstbxWatched_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProgressBar pro = (ProgressBar)this.Tag;
            pro.Value = 5;
            Movie movie = (Movie)lstbxWatched.SelectedItem;
            DbMethods.DbHasMovie(movie);
            pro.Value = 20;
            FormMovie form = new FormMovie();
            form.MdiParent = this.MdiParent;
            form._Movie = movie;
            form.Tag = pro;
            form.Show();
        }

        private void LstbxWatch_SelectedIndexChanged(object sender, EventArgs e)
        {

            ProgressBar pro = (ProgressBar)this.Tag;
            pro.Value = 5;
            Movie movie = (Movie)lstbxWatch.SelectedItem;
            DbMethods.DbHasMovie(movie);
            pro.Value = 20;
            FormMovie form = new FormMovie();
            form.MdiParent = this.MdiParent;
            form._Movie = movie;
            form.Tag = pro;
            form.Show();
        }
    }
}
