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
            Validate val = new Validate();
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
                                    check = true;
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
            if (check)
            {
                Database a = new Database();
                int ageNum;
                Int32.TryParse(age.Text, out ageNum);
                a.storeData("Users", "fName, lName, age, Username, Pass", "'" + fname.Text + "', '" + lName.Text + "', " + ageNum + ", '" + usr.Text + "', '" + pass.Text + "'");
                MessageBox.Show("Registration succeeded!!!");
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
