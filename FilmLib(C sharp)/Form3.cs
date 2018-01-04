using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Collections;
//using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmLib_C_sharp_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            bool check = false;
            Database a = new Database();
            //database object created
            Validate val = new Validate();
            //validation object created
            if (val.onlyLettersVal(fname.Text))
            {
                if (val.onlyLettersVal(lName.Text))
                {
                    if (val.ageVal(age.Text))
                    {
                        if (val.UsrAndPassVal(usr.Text))
                        {
                            if (val.UsrAndPassVal(pass.Text))
                            {
                                if(string.Compare(pass.Text, confirmPass.Text) == 0)
                                {
                                    List<object> rslt = a.getData("Users", "Username", "Username = '" + usr.Text + "'");
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
                a.storeData("Users", "fName, lName, age, Username, Pass", "'" + fname.Text + "', '" + lName.Text + "', " + age.Text + ", '" + usr.Text + "', '" + pass.Text + "'");
                MessageBox.Show("Registration succeeded!!!");
                this.Close();
            }
            //storing data completed
            a.Dispose();
            //release database object
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
