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
    public partial class Form4 : Form
    {
        private User usr_;
        private BindingSource bs_;
        public Form4(ref User user)
        {
            InitializeComponent();
            bs_ = new BindingSource();
            usr_ = user;
            nameLbl.Text += "Hi " + usr_.getName();
            ageLbl.Text += " " + usr_.getAge().ToString();
            genderLbl.Text += " " + usr_.getGender();
            bs_.DataSource = usr_.getFavourites();
            filmList.DataSource = bs_;
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            
            bs_.Dispose();
            this.Close();
            
        }

        private void rmBtn_Click(object sender, EventArgs e)
        {
            Database a = new Database();
            //Film temp = new Film(filmList.SelectedItem.ToString());
            Film temp = (Film)filmList.SelectedItem;
            a.rmRow("UserFilm", "UserID = " + usr_.getUserID().ToString() + " AND FilmID = "+ temp.getFilmId().ToString());

            usr_.getFavourites().Remove((Film)filmList.SelectedItem);

            bs_.ResetBindings(false);
            
            a.Dispose();
        }
        public void resetBs()
        {
            bs_.ResetBindings(false);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Database a = new Database();
            List<object> matched = a.getData("Films", "Name", "Name LIKE '%" + search.Text + "%'");
            List<Film> matchedFilm = new List<Film>();
           
            for(int i = 0; i < matched.Count; i++)
            {
                
                Film temp = new Film(matched[i].ToString());
                temp.importFilm();
                matchedFilm.Add(temp);
            }
            Form5 frm5 = new Form5(ref matchedFilm, ref usr_, this);
            frm5.Show();
            this.Closed += (s, args) => frm5.Close();
            a.Dispose();
        }
    }
}
