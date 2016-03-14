using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film02
{
    public class Film
    {
        public string Name
        {
            get;
            set;
        }

        public string Country
        {
            get;
            set;
        }

        public string Category
        {
            get;
            set;
        }

        public float Rating
        {
            get;
            set;
        }

        public Film(string name, string country, string category, float rating)
        {
            Name = name;
            Country = country;
            Category = category;
            Rating = rating;
        }
    }
}
