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
    public partial class FormMovie : Form
    {
        public Movie _Movie { get; set; }
        public FormMovie()
        {
            InitializeComponent();
        }

        private void FormMovie_Load(object sender, EventArgs e)
        {
            ProgressBar pro = (ProgressBar)this.Tag;
            this.WindowState = FormWindowState.Maximized;
            this.Text = _Movie.Name;

            rchbxRate.Text = _Movie.Rate.ToString();
            rchbxDescription.Text = _Movie.Description;
            rchbxDate.Text = _Movie.Date.ToString();
            pro.Value = 30;

            rchbxMyRate.Text = DbMethods.DbFindMyRate(_Movie);
            

            if (_Movie.Poster != "") pbxPoster.Load(_Movie.Poster);
            else pbxPoster.Load("https://us.123rf.com/450wm/pavelstasevich/pavelstasevich1811/pavelstasevich181101065/112815953-stock-vector-no-image-available-icon-flat-vector.jpg?ver=6");

            _Movie.FindCast();
            pro.Value = 40;

            int incrementCast = Convert.ToInt32(50 / _Movie.Casts.Count);
            int incrementRole;
            
            foreach (Cast cast in _Movie.Casts)
            {
                incrementRole = Convert.ToInt32(incrementCast / cast.Roles.Count);

                foreach (String role in cast.Roles)
                {
                    rchbxRole.Text += role+",";   
                    pro.Value += incrementRole;
                }
                rchbxRole.Text += "\n";
                lstbxCast.Items.Add(cast);
            }
            List<Genre> genres = DbMethods.DbFindMovieGenre(_Movie.MovieId);
            if (genres.Count == 0)
            {
                _Movie.FindGenre();
                genres = _Movie.Genres;
            }        
            pro.Value = 100;
            foreach(Genre genre in genres)
            {
                DbMethods.DbHasGenre(genre);
                lstbxGenre.Items.Add(genre);
            }
        }

        private void LstbxCast_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProgressBar pro=(ProgressBar)this.Tag;
            pro.Value = 5;
            Cast cast = (Cast)lstbxCast.SelectedItem;
            DbMethods.DbHasPerson(cast);
            pro.Value = 15;
            foreach(String role in cast.Roles)
            {
                int id=DbMethods.DbHasRole(role);  //yeni role varsa db ye ekler
                DbMethods.DbHasMoviePerson(_Movie.MovieId, cast.CastId, id);
            }
            pro.Value = 35;
            FormCast form = new FormCast();
            form.MdiParent = this.MdiParent;
            form._Cast = cast;
            form.Tag = pro;
            form.Show();
        }

        private void LstbxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            (this.Tag as ProgressBar).Value = 5;
            Genre genre = (Genre)lstbxGenre.SelectedItem;
            int id=DbMethods.DbHasGenre(genre);
            (this.Tag as ProgressBar).Value = 15;
            DbMethods.DbHasMovieGenre(_Movie.MovieId, id);
            (this.Tag as ProgressBar).Value = 30;
            FormGenre form = new FormGenre();
            form.MdiParent = this.MdiParent;
            form.Tag = this.Tag;
            form._Genre = genre;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            (this.Tag as ProgressBar).Value = 5;
            FormImage form = new FormImage();
            form.MdiParent = this.MdiParent;
            form.Tag = this.Tag;
            form._Movie = _Movie;
            form.WindowState = FormWindowState.Maximized;
            form.Show();

        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            int status;
            if (checkbxWatched.Checked) status = 1;
            else  status = 0;
            if (rchbxMyRate.Text != "")
            {
                DbMethods.DbHasMovieWatch(_Movie, status, Convert.ToDouble(rchbxMyRate.Text));
                MessageBox.Show("Kayıtlar güncenlendi");
            }
            else
            {
                DbMethods.DbHasMovieWatch(_Movie, status, Convert.ToDouble(0));
                MessageBox.Show("Kayıtlar güncenlendi");
            }
        }

        private void CheckbxWatch_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxWatch.Checked)
            {
                checkbxWatched.Enabled = false;
                rchbxMyRate.Enabled = false;
            }
            else
            {
                checkbxWatched.Enabled = true;
                rchbxMyRate.Enabled = true;
            }
        }

        private void CheckbxFavorite_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxWatched.Checked)
            {
                checkbxWatch.Enabled = false;
                
            }
            else
            {
                checkbxWatch.Enabled = true;
               
            }
        }
    }
}
