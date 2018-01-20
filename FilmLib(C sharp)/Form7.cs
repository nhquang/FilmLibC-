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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        
        private void addBtn_Click(object sender, EventArgs e)
        {
            bool check = false;
            
            Validate val = new Validate();
            if (val.LettersAndNum(nameT.Text))
            {
                if (val.onlyLettersVal(genre.Text))
                {
                    if (val.LettersAndCommas(casts.Text))
                    {
                        Database a = new Database();
                        List<object> rslt = a.getData("Films", "Name", "Name = '" + nameT.Text + "'");
                        a.Dispose();
                        if(rslt.Count == 0)
                        {
                            check = true;
                        }
                        else
                        {
                            MessageBox.Show("This movie already exists");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Casts can only contain letters and 3 commas");
                    }
                }
                else
                {
                    MessageBox.Show("Genre can only contain letters");
                }
            }
            else
            {
                MessageBox.Show("Name can only contain letters and numbers");
            }
            if (check)
            {
                Database a = new Database();
                a.storeData("Films", "Name, Descript, rate, Genre, tralerLink, imageLink, casts", "'" + nameT.Text + "', '" + descript.Text + "', " + ratingVal.Value + ", '" + genre.Text + "', '" + trailer.Text + "', '" + image.Text + "', '" + casts.Text + "'");
                MessageBox.Show("Movie is added");
                a.Dispose();
                
            }
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
