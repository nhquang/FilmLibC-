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
        private string gender_;
        private bool admin_;
        private List<Film> favourites_;
        public User(string username)
        {
            username_ = username;
            favourites_ = new List<Film>();
        }
        public void importUser()                                                    //get user data from database
        {
            Database a = new Database();                                            //new database instance

            List<object> userId = a.getData("Users", "UserID", "Username = '" + username_ + "'");
            userId_ = Convert.ToInt16(userId[0]);
          

            List<object> lName = a.getData("Users", "lName", "Username = '" + username_ + "'");
            lName_ = lName[0].ToString();     
            
            List<object> fName = a.getData("Users", "fName", "Username = '" + username_ + "'");
            fName_ = fName[0].ToString();

            List<object> age = a.getData("Users", "age", "Username = '" + username_ + "'");
            age_ = Convert.ToInt16(age[0]);

            
            List<object> gender = a.getData("Users", "gender", "Username = '" + username_ + "'");
            gender_ = gender[0].ToString();

            List<object> admin = a.getData("Users", "admin", "Username = '" + username_ + "'");            
            admin_ = (bool)admin[0];
            
            List<object> favourites = a.getDataFromJoin("Films", "UserFilm", "FilmID", "name", "UserID=" + userId_.ToString());        
            for(int i = 0; i < favourites.Count; i++)
            {
                
                Film temp = new Film(favourites[i].ToString());
                
                temp.importFilm();
                
                favourites_.Add(temp);
            }

            a.Dispose();                                                            //free up memory space used by "a", whenever GC is available
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
        public string getGender()
        {
            return gender_;
        }
        public bool getAdmin()
        {
            return admin_;
        }
        public List<Film> getFavourites()
        {
            
            return favourites_;
        }
    }
}
