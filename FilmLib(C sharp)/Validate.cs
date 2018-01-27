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
            Regex pattern = new Regex(@"^[a-zA-Z]+$");
            return pattern.IsMatch(name);
            
        }
        public bool numOnlyVal(string num)
        {
            Regex pattern = new Regex(@"^[0-9][0-9]$");
            return pattern.IsMatch(num);
        }

        /*public bool usernameVal(string usr)
        {
            Regex pattern = new Regex(@"^[0-9a-zA-Z]*$");
            return pattern.IsMatch(usr);
        }*/
        public bool LettersAndNum(string val)
        {
            Regex pattern = new Regex(@"^[0-9a-zA-Z]+$");
            return pattern.IsMatch(val);
        }
        public bool LettersAndCommas(string val)
        {
            Regex pattern = new Regex(@"^[a-zA-Z\s]+,\s[a-zA-Z\s]+,\s[a-zA-Z\s]+$");
            return pattern.IsMatch(val);
        }
        public bool imageURLVal(string val)
        {
            Regex pattern = new Regex(@"^http.+.(png|jpg){1}$");
            return pattern.IsMatch(val);
        }
        public bool trailerURLVal(string val)
        {
            Regex pattern = new Regex(@"^https:.+$");
            return pattern.IsMatch(val);
        }
    }
}
