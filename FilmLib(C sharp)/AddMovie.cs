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
    public partial class AddMovie : Form
    {
        public AddMovie()
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
                    if (val.trailerURLVal(trailer.Text))
                    {
                        if (val.imageURLVal(image.Text))
                        {
                            if (val.LettersAndCommas(casts.Text))
                            {
                                Database a = new Database();
                                List<object> rslt = a.getData("Films", "Name", "Name = '" + nameT.Text + "'");
                                a.Dispose();
                                if (rslt.Count == 0)
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
                                MessageBox.Show("Format: actor, actor, actor. Digits are not allowed");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Should be a .jpg or .png URL");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Format: https:");
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
                a.storeData("Films", "Name, Descript, rate, Genre, trailerLink, imageLink, casts", "'" + nameT.Text + "', '" + descript.Text + "', " + ratingVal.Value + ", '" + genre.Text + "', '" + trailer.Text + "', '" + image.Text + "', '" + casts.Text + "'");
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
