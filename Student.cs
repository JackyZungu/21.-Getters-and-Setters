using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Getters_and_Setters
{
    class Movie
    {
        public string title;
        public string director;
        private string rating;

        public Movie(string aTitle, string aDirector, string aRating)
        {
            this.title = aTitle;
            this.director = aDirector;
            this.Rating = aRating;
        }
        public string Rating
        {
            get { return rating; }

            set
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "")
                {
                    rating = value;
                }
                  else

                  {
                    rating = "NR";

                  }
            }
        }
    }

            
        
    
}
