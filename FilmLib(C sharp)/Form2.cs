using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmLib_C_sharp_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Database a = new Database();
            List<object> matchedUser =  a.getData("Users", "Username", "Username = '" + usr.Text + "'");
            if(matchedUser.Count > 0)
            {
                List<object> matchedPass = a.getData("Users", "Pass", "Username = '" + usr.Text + "'");
                if (string.Compare(matchedPass[0].ToString(), pass.Text) == 0)
                {
                    MessageBox.Show("Succeeded!!!");
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect");
                }
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect");
            }

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
