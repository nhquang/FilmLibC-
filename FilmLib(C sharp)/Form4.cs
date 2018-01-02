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
        public Form4(User user)
        {
            InitializeComponent();
            usr_ = user;
            nameLbl.Text += "Hi " + usr_.getName();
            ageLbl.Text += usr_.getAge().ToString();
            rateLbl.Text += usr_.getRated().ToString();
            filmList.DataSource = usr_.getFavourites();
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            //GC.Collect();
        }
    }
}
