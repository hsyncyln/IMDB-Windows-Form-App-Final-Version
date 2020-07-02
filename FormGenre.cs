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
    public partial class FormGenre : Form
    {
        public Genre _Genre { get; set; }
        public FormGenre()
        {
            InitializeComponent();
        }

        private void FormGenre_Load(object sender, EventArgs e)
        {
            (this.Tag as ProgressBar).Value = 45;
            lstbxGenreMovies.Items.Clear();
            lblName.Text = _Genre.GenreName;

            WebClient webClient = new WebClient();
            string result = webClient.DownloadString("https://www.imdb.com" + _Genre.GenreUrl);

            int startsWith, endsWith;
            string movieUrl, movieName;
           
            while (result.IndexOf("filmosearch") != -1)
            {
                startsWith = result.IndexOf("filmosearch");
                result = result.Substring(startsWith);

                startsWith = result.IndexOf("<a href=");
                result = result.Substring(startsWith);
                startsWith = result.IndexOf('"');
                result = result.Substring(startsWith + 1);
                endsWith = result.IndexOf('"');

                movieUrl = result.Substring(0, endsWith);

                startsWith = result.IndexOf("alt=");
                result = result.Substring(startsWith);
                startsWith = result.IndexOf('"');
                result = result.Substring(startsWith + 1);
                endsWith = result.IndexOf('"');

                movieName = result.Substring(0, endsWith);

                Movie movie = new Movie(movieName, movieUrl);
                lstbxGenreMovies.Items.Add(movie);
                
            }
            (this.Tag as ProgressBar).Value = 100;

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Movie movie = (Movie)lstbxGenreMovies.SelectedItem;
            ProgressBar pro = (ProgressBar)this.Tag;
            pro.Value = 5;
            DbMethods.DbHasMovie(movie);
            pro.Value = 15;
            FormMovie form = new FormMovie();
            form.MdiParent = this.MdiParent;
            form.WindowState = FormWindowState.Maximized;
            form._Movie = movie;
            pro.Value = 20;
            form.Tag = pro;
            form.Show();
        }
    }
}
