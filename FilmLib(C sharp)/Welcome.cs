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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn a = new LogIn();
            a.Show();
            a.Closed += (s, args) => this.Show();
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register b = new Register();
            b.Show();
            b.Closed += (s, args) => this.Show(); //open form1 while closing form3
            
            
        }
    }
}
