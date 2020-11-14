using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmLib_C_sharp_
{
    public partial class LogIn : Form  
    {
        public LogIn()
        {
            InitializeComponent();
            this.AcceptButton = loginBtn;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(usr.Text) && !string.IsNullOrEmpty(pass.Text))
            {
                bool check = false;                                                                                 //database object created
                Database a = new Database();
                List<object> matchedUser = a.getData("Users", "Username", "Username = '" + usr.Text + "'");        //look for a matched username
                if (matchedUser.Count > 0)                                                                           //perform password validation for the matched username
                {
                    List<object> savedPass = a.getData("Users", "Pass", "Username = '" + usr.Text + "'");

                    if (checkHashedPasswords(savedPass[0].ToString()))
                    {
                        MessageBox.Show("Succeeded!!!");
                        check = true;
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
                a.Dispose();                                                                                        //free up memory space used by "a", whenever GC is available
                if (check)
                {
                    User initiateUser = new User(usr.Text);                                                         //new User object created

                    initiateUser.importUser();                                                                      //pull user's info from database

                    Dashboard frm4 = new Dashboard(ref initiateUser);                                                           //pass User object to Dashboard form

                    frm4.Show();
                    this.Hide();
                    frm4.Closed += (s, args) => this.Close();                                                       //when dashboard form closed, log in form closed too

                }
            }
        }

        private bool checkHashedPasswords(string storedPwd)
        {
            bool check = true;                                                                             //authenticate the hashed password
            byte[] hashBytes = Convert.FromBase64String(storedPwd);
            byte[] salt = new byte[16];
            Array.ConstrainedCopy(hashBytes, 0, salt, 0, 16);
            using (var pbkdf2 = new Rfc2898DeriveBytes(pass.Text, salt, 10000))
            {
                byte[] hash = pbkdf2.GetBytes(20);
                for (int i = 0; i < 20; i++)
                {
                    if (hashBytes[i + 16] != hash[i])
                    {
                        check = false;
                        break;
                    }
                }
            }
            return check;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();       
        }
    }
}
