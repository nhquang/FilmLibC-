using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FilmLib_C_sharp_
{
    public class Validate
    {
        public Validate()
        {

        }
        public bool onlyLettersVal(string name)
        {
            Regex pattern = new Regex(@"^[a-zA-Z]*$");
            return pattern.IsMatch(name);
            
        }
        public bool ageVal(string age)
        {
            Regex pattern = new Regex(@"^[0-9][0-9]$");
            return pattern.IsMatch(age);
        }

        /*public bool usernameVal(string usr)
        {
            Regex pattern = new Regex(@"^[0-9a-zA-Z]*$");
            return pattern.IsMatch(usr);
        }*/
        public bool UsrAndPassVal(string val)
        {
            Regex pattern = new Regex(@"^[0-9a-zA-Z]*$");
            return pattern.IsMatch(val);
        }
    }
}
