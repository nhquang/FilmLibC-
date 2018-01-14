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
    public partial class Form5 : Form
    {
        private User usr_;
        private Form4 frm4_;
        
        public Form5(ref List<Film> matched, ref User usr, Form4 frm4)          //prepare the listView with matched movies
        {
            InitializeComponent();
            usr_ = usr;
            frm4_ = frm4;
            for(int i = 0; i < matched.Count; i++)
            {
                //MessageBox.Show(matched[i].ToString());
                ListViewItem temp = new ListViewItem(matched[i].ToString());
                temp.SubItems.Add(matched[i].getGenre());
                temp.SubItems.Add(matched[i].getRate().ToString());
                results.Items.Add(temp);
               
            }
        }

        private void detailsBtn_Click(object sender, EventArgs e)
        {
            if (results.SelectedItems.Count > 1)
            {
                MessageBox.Show("Cannot select more than one movie");
            }
            else if (results.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select a movie");        
            }
            else
            {
                Form6 frm6 = new Form6(results.SelectedItems[0].Text, ref usr_, ref frm4_);
                frm6.Show();
                frm4_.Closed += (s, args) => frm6.Close();                  //when users sign out, close the movie info page 
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
        
      
            this.Close();
        }
    }
}
