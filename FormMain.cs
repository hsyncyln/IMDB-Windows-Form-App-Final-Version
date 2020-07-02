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
    public partial class FormMain : Form
    {
         List<Movie> _listmovies;
        public FormMain()
        {
            InitializeComponent();
        }
        public void Findmovie(string txt)  //film isimlerini ve urllerini listeye atar
        {
            WebClient webClient = new WebClient();
            string result = webClient.DownloadString("https://www.imdb.com/find?q=" + txt);

            string movieName, movieUrl;

            int startsWith = result.IndexOf("table");     //filmler <table> ların arasında olduğundan kontrol edilecek data azaltıldı
            int endsWith = result.IndexOf("/table");
            if (startsWith == -1) return;
            string movie_table = result.Substring(startsWith, endsWith - startsWith);


            while (movie_table.IndexOf("result_text") != -1)  // '/title' ile başlayan kısımlar listelenmiş filmleri url leridir. 
            {                                           //Eğer -1 ise aranan filmlerin url leri alınmıştır

                startsWith = movie_table.IndexOf("/title");          //ilk url'in başlangıç noktasını bulur
                movie_table = movie_table.Substring(startsWith + 1);    //başlangıç noktasını bulunan yere taşır

                startsWith = movie_table.IndexOf("/title");          //ikinci url'in başlangıç noktasını bulur ve taşır
                movie_table = movie_table.Substring(startsWith);
                endsWith = movie_table.IndexOf('?');               // url " işaretine kadar olan kısım olduğundan son noktasını buldum

                movieUrl = movie_table.Substring(0, endsWith);  //bulduğumuz url 

                endsWith = movie_table.IndexOf(">");
                movie_table = movie_table.Substring(endsWith + 1);     //filmlerin isimlerini bulabilmek için bulduğumuz yeri çıkarıyoruz
                endsWith = movie_table.IndexOf("<");

                movieName = movie_table.Substring(0, endsWith);

                startsWith = movie_table.IndexOf(">");
                movie_table = movie_table.Substring(startsWith + 1);
                endsWith = movie_table.IndexOf("<");

                movieName += movie_table.Substring(0, endsWith);

                Movie movie = new Movie(movieName, movieUrl);  //movie tipinde bir instance olusturur
                _listmovies.Add(movie);

                movie_table = movie_table.Substring(endsWith + 1);
            }

        }
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            ProgressBar pro = (ProgressBar)this.Tag;
            pro.Value = 0;

            //Movie listbox ına filmleri atar
            cmbbxSearch.Items.Clear();

            _listmovies = new List<Movie>();

            pro.Value = 10;

            Findmovie(txtbx.Text);

            pro.Value = 30;

            if (_listmovies == null && txtbx.Text == "")
            {
                MessageBox.Show("Lütfen aratılacak bir değer giriniz");
                return;
            }
            else if (_listmovies == null && txtbx.Text != "")
            {
                MessageBox.Show("Aradıgınız sorgu bulunamamakta");
                return;
            }
            pro.Value = 40;

            int increment = Convert.ToInt32(60 / _listmovies.Count);

            foreach (Movie movie in _listmovies)
            {
                cmbbxSearch.Items.Add(movie);
                pro.Value += increment;
            }
            pro.Value = 100;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Movie movie = (Movie)cmbbxSearch.SelectedItem;

            ProgressBar pro = (ProgressBar)this.Tag;
            pro.Value = 0;
            DbMethods.DbHasMovie(movie);
            pro.Value = 10;
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
