using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLib_C_sharp_
{
    public class Film
    {
        private int filmId_;
        private string name_;
        private string descript_;
        private int rate_;
        private string imageLink_;
        private string genre_;
        private string trailerLink_;
        public Film(string name)
        {
            name_ = name;
        }
        public void importFilm()
        {
            Database a = new Database();
            List<object> filmId = a.getData("Users", "FilmID", "Username = '" + name_ + "'");
            filmId_ = (int)filmId[0];
            List<object> des = a.getData("Users", "Descript", "Username = '" + name_ + "'");
            descript_ = des[0].ToString();
            List<object> rate = a.getData("Users", "rate", "Username = '" + name_ + "'");
            rate_ = (int)rate[0];
            List<object> image = a.getData("Users", "imageLink", "Username = '" + name_ + "'");
            imageLink_ = image[0].ToString();
            List<object> genre = a.getData("Users", "Genre", "Username = '" + name_ + "'");
            genre_ = genre[0].ToString();
            List<object> trailer = a.getData("Users", "trailerLink", "Username = '" + name_ + "'");
            trailerLink_ = trailerLink_[0].ToString();
            
        }
    }
}
