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
    public partial class FormImage : Form
    {
        public Movie _Movie { get; set; }
        public Cast _Cast { get; set; }
        public FormImage()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {

            (this.Tag as ProgressBar).Value = 10;
            if (_Movie != null)
            {
                DbMethods.DbHasMovieImage(_Movie);

                (this.Tag as ProgressBar).Value = 25;

                for (int i = 0; i < _Movie.Pictures.Count; i++)
                {
                    
                    if (i == 0)
                    {
                        pictureBox1.Load(_Movie.Pictures[i].ImageUrl);
                        pictureBox1.Visible = true;
                        richTextBox1.Text = _Movie.Pictures[i].ImageName;
                        richTextBox1.Visible = true;
                        (this.Tag as ProgressBar).Value +=10;
                    }
                    else if (i == 1)
                    {
                        pictureBox2.Load(_Movie.Pictures[i].ImageUrl);
                        pictureBox2.Visible = true;
                        richTextBox2.Text = _Movie.Pictures[i].ImageName;
                        richTextBox2.Visible = true;
                        (this.Tag as ProgressBar).Value +=10;
                    }
                    else if (i == 2)
                    {
                        pictureBox3.Load(_Movie.Pictures[i].ImageUrl);
                        pictureBox3.Visible = true;
                        richTextBox3.Text = _Movie.Pictures[i].ImageName;
                        richTextBox3.Visible = true;
                        (this.Tag as ProgressBar).Value +=10;
                    }
                    else if (i == 3)
                    {
                        pictureBox4.Load(_Movie.Pictures[i].ImageUrl);
                        pictureBox4.Visible = true;
                        richTextBox4.Text = _Movie.Pictures[i].ImageName;
                        richTextBox4.Visible = true;
                        (this.Tag as ProgressBar).Value +=10;
                    }
                    else if (i == 4)
                    {
                        pictureBox5.Load(_Movie.Pictures[i].ImageUrl);
                        pictureBox5.Visible = true;
                        richTextBox5.Text = _Movie.Pictures[i].ImageName;
                        richTextBox5.Visible = true;
                        (this.Tag as ProgressBar).Value +=10;
                    }
                    else if (i == 5)
                    {
                        pictureBox6.Load(_Movie.Pictures[i].ImageUrl);
                        pictureBox6.Visible = true;
                        richTextBox6.Text = _Movie.Pictures[i].ImageName;
                        richTextBox6.Visible = true;
                        (this.Tag as ProgressBar).Value +=10;
                    }
                }  

            }
            else
            {

                DbMethods.DbHasPersonImage(_Cast);

                (this.Tag as ProgressBar).Value = 25;

                for (int i = 0; i < _Cast.Pictures.Count; i++)
                {

                    if (i == 0)
                    {
                        pictureBox1.Load(_Cast.Pictures[i].ImageUrl);
                        pictureBox1.Visible = true;

                        richTextBox1.Text = _Cast.Pictures[i].ImageName;
                        richTextBox1.Visible = true;
                        (this.Tag as ProgressBar).Value += 10;
                    }
                    else if (i == 1)
                    {
                        pictureBox2.Load(_Cast.Pictures[i].ImageUrl);
                        pictureBox2.Visible = true;
                        richTextBox2.Text = _Cast.Pictures[i].ImageName;
                        richTextBox2.Visible = true;
                        (this.Tag as ProgressBar).Value +=10;
                    }
                    else if (i == 2)
                    {
                        pictureBox3.Load(_Cast.Pictures[i].ImageUrl);
                        pictureBox3.Visible = true;
                        richTextBox3.Text = _Cast.Pictures[i].ImageName;
                        richTextBox3.Visible = true;
                        (this.Tag as ProgressBar).Value +=10;
                    }
                    else if (i == 3)
                    {
                        pictureBox4.Load(_Cast.Pictures[i].ImageUrl);
                        pictureBox4.Visible = true;
                        richTextBox4.Text = _Cast.Pictures[i].ImageName;
                        richTextBox4.Visible = true;
                        (this.Tag as ProgressBar).Value +=10;
                    }
                    else if (i == 4)
                    {
                        pictureBox5.Load(_Cast.Pictures[i].ImageUrl);
                        pictureBox5.Visible = true;
                        richTextBox5.Text = _Cast.Pictures[i].ImageName;
                        richTextBox5.Visible = true;
                        (this.Tag as ProgressBar).Value +=10;
                    }
                    else if (i == 5)
                    {
                        pictureBox6.Load(_Cast.Pictures[i].ImageUrl);
                        pictureBox6.Visible = true;
                        richTextBox6.Text = _Cast.Pictures[i].ImageName;
                        richTextBox6.Visible = true;
                        (this.Tag as ProgressBar).Value +=10;
                    }
                }

            }
            (this.Tag as ProgressBar).Value = 100;
        }

    
    }
}
