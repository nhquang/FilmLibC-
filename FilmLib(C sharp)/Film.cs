using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private string casts_;
        public Film(string name)
        {
            name_ = name;
        }
        public void importFilm()                                        //get film data from database
        {
            Database a = new Database();                                //new instance of database class

            List<object> filmId = a.getData("Films", "FilmID", "Name = '" + name_ + "'");
            filmId_ = Convert.ToInt16(filmId[0]);
            
            List<object> des = a.getData("Films", "Descript", "Name = '" + name_ + "'");
            descript_ = des[0].ToString();
            
            List<object> rate = a.getData("Films", "rate", "Name = '" + name_ + "'");
            rate_ = Convert.ToInt16(rate[0]);

            List<object> image = a.getData("Films", "imageLink", "Name = '" + name_ + "'");
            imageLink_ = image[0].ToString();

            List<object> genre = a.getData("Films", "Genre", "Name = '" + name_ + "'");
            genre_ = genre[0].ToString();

            List<object> trailer = a.getData("Films", "trailerLink", "Name = '" + name_ + "'");    
            trailerLink_ = trailer[0].ToString();

            List<object> casts = a.getData("Films", "casts", "Name = '" + name_ + "'");
            casts_ = casts[0].ToString();

            a.Dispose();                                               //free up memory space used by "a", whenever GC is available 
        }
        public int getFilmId()
        {
            return filmId_;
        }
        public string getName()
        {
            return name_;
        }
        public string getDescript()
        {
            return descript_;
        }
        public int getRate()
        {
            return rate_;
        }
        public string getImageLink()
        {
            return imageLink_;
        }
        public string getTrailerLink()
        {
            return trailerLink_;
        }
        public string getCasts()
        {
            return casts_;
        }
        public string getGenre()
        {
            return genre_;
        }
        public override string ToString()
        {
            return name_;
        }
    }
}
