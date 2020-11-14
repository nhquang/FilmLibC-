using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
//using System.Collections;
//using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmLib_C_sharp_
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            bool check = false;
            
            //database object created
            Validate val = new Validate();
            //validation object created
            if (val.onlyLettersVal(fname.Text))
            {
                if (val.onlyLettersVal(lName.Text))
                {
                    if (val.numOnlyVal(age.Text))
                    {
                        if (val.LettersAndNum(usr.Text))
                        {
                            if (val.LettersAndNum(pass.Text))
                            {
                                if(string.Compare(pass.Text, confirmPass.Text) == 0)
                                {
                                    Database a = new Database();
                                    List<object> rslt = a.getData("Users", "Username", "Username = '" + usr.Text + "'");
                                    a.Dispose();
                                    if (rslt.Count == 0)
                                    {
                                        check = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Username already exists");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Confirm password isn't matching password");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Password can only contain letters, and digits");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username can only contain letters, and digits");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Age must be only digits");
                    }
                }
                else
                {
                    MessageBox.Show("Last name must be only letters");
                }
            }
            else
            {
                MessageBox.Show("First name must be only letters");
            }
            //Validation completed
            if (check)
            {
                string gender = "Male";
                if (female.Checked)
                {
                    gender = "Female";
                }
                //Hash Pwd
                var hashedPwd = hashPwd(this.pass.Text);
                //finished hashing password
                //database object created
                Database a = new Database();
                a.storeData("Users", "fName, lName, age, Username, Pass, gender", "'" + fname.Text + "', '" + lName.Text + "', " + age.Text + ", '" + usr.Text + "', '" + hashedPassword + "', '" + gender + "'");
                a.Dispose();
                MessageBox.Show("Registration succeeded!!!");
                this.Close();
            }
            
            //storing data completed
            
            
        }

        private string hashPwd(string pwd)
        {
            string hashed = string.Empty;
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            using (var pbkdf2 = new Rfc2898DeriveBytes(pwd, salt, 10000))
            {
                byte[] hash = pbkdf2.GetBytes(20);
                byte[] hashBytes = new byte[36];
                Array.ConstrainedCopy(salt, 0, hashBytes, 0, 16);
                Array.ConstrainedCopy(hash, 0, hashBytes, 16, 20);
                hashed = Convert.ToBase64String(hashBytes);
            }
            return hashed;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
