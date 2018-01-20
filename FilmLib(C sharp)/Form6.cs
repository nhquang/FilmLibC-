using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmLib_C_sharp_
{
    public partial class Form6 : Form
    {
        private Form4 frm4_;
        private User usr_;
        private Film film_;
        public Form6(string filmNamee, ref User usr, Form4 frm4)
        {
            InitializeComponent();
            usr_ = usr;
            frm4_ = frm4;
            film_ = new Film(filmNamee);
            film_.importFilm();
            filmName.Text = film_.getName();
            descriptText.Text = film_.getDescript();
            genreText.Text = film_.getGenre();
            ratingText.Text = film_.getRate().ToString() + " /10";
            castText.Text = film_.getCasts();
            image.ImageLocation = film_.getImageLink();
            image.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            
            int check = 0;
            for(int i = 0; i < usr_.getFavourites().Count; i++)
            {
                if (String.Compare(film_.getName(), usr_.getFavourites()[i].getName()) == 0)
                {
                    
                    check = 1;
                    MessageBox.Show("This film is already in your favourite list");
                    break;
                }
            }
            
            if (check == 0)
            {
                Database a = new Database();
                a.storeData("UserFilm", "UserID, FilmID", usr_.getUserID().ToString() + ", " + film_.getFilmId().ToString());
                usr_.getFavourites().Add(film_);
                frm4_.resetBs();                //update listbox in frm4_ after usr_.favourites_ gets updated
                MessageBox.Show("Added to your favourites");
                a.Dispose();
            }
            
            
        }

        private void trailer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(film_.getTrailerLink());
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(image.IsDisposed.ToString());
            image.Dispose();
            //MessageBox.Show(image.IsDisposed.ToString());
           
            this.Close();
            
        }
    }
}
