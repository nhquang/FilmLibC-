using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmLib_C_sharp_
{
    public class User
    {
        private int userId_;
        private string username_;
        private string lName_;
        private string fName_;
        private int age_;
        private int rated_;
        private bool admin_;
        private List<object> favourites_;
        public User(string username)
        {
            username_ = username;
        }
        public void importUser()
        {
            Database a = new Database();

            List<object> userId = a.getData("Users", "UserID", "Username = '" + username_ + "'");
            userId_ = Convert.ToInt16(userId[0]);
          

            List<object> lName = a.getData("Users", "lName", "Username = '" + username_ + "'");
            lName_ = lName[0].ToString();     
            
            List<object> fName = a.getData("Users", "fName", "Username = '" + username_ + "'");
            fName_ = fName[0].ToString();

            List<object> age = a.getData("Users", "age", "Username = '" + username_ + "'");
            age_ = Convert.ToInt16(age[0]);

            
            List<object> rated = a.getData("Users", "RATED", "Username = '" + username_ + "'");
            rated_ = Convert.ToInt16(rated[0]);

            List<object> admin = a.getData("Users", "admin", "Username = '" + username_ + "'");            
            admin_ = (bool)admin[0];

            List<object> favourites = a.getDataFromJoin("Films", "UserFilm", "FilmID", "name", "UserID=" + userId_.ToString());        
            favourites_ = favourites;
        }
        public int getUserID()
        {
            return userId_;
        }
        public string getUsername()
        {
            return username_;
        }
        public string getName()
        {
            return fName_ + ", " + lName_;
        }
        public int getAge()
        {
            return age_;
        }
        public int getRated()
        {
            return rated_;
        }
        public bool getAdmin()
        {
            return admin_;
        }
        public List<object> getFavourites()
        {
            
            return favourites_;
        }
    }
}
