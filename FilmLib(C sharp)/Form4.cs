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
        public Form4(ref User user)                             //prepare the dashboard with the user's info
        {
            InitializeComponent();
            bs_ = new BindingSource();
            usr_ = user;
            nameLbl.Text += "Hi " + usr_.getName();
            ageLbl.Text += " " + usr_.getAge().ToString();
            genderLbl.Text += " " + usr_.getGender();
            bs_.DataSource = usr_.getFavourites();             //bs datasource and usr_.favourites are pointing to the same memory allocation
            filmList.DataSource = bs_;                         //bs datasource and filmList datasource are pointing to the same memory allocation
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            
            bs_.Dispose();
            this.Close();
            
        }

        private void rmBtn_Click(object sender, EventArgs e)
        {
            if (filmList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select a movie");
            }
            else
            {
                Database a = new Database();

                Film temp = (Film)filmList.SelectedItem;
                a.rmRow("UserFilm", "UserID = " + usr_.getUserID().ToString() + " AND FilmID = " + temp.getFilmId().ToString());

                usr_.getFavourites().Remove((Film)filmList.SelectedItem);     //selected film is removed from usr_.favourites_ 

                bs_.ResetBindings(false);                       //update the listbox after an object is removed from usr_ favourite list

                a.Dispose();
            }
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
            this.Closed += (s, args) => frm5.Close();                       //when dashboard closed, the search result form get closed too
            a.Dispose();
        }

        private void detailBtn_Click(object sender, EventArgs e)
        {
            if (filmList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select a movie");
            }
            else
            {
                Form6 frm6 = new Form6(filmList.SelectedItem.ToString(), ref usr_, this);
                frm6.Show();
                this.Closed += (s, args) => frm6.Close();
            }
        }

        private void addMovBtn_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.Show();
            this.Closed += (s, args) => frm7.Close();
        }
    }
}
