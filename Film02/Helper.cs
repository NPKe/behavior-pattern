using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film02
{
    public class Helper
    {
        public virtual bool isSelected(Film film)
        {
            return true;
        }
    }

    public class CountryHelper : Helper
    {
        private string Country;

        public CountryHelper(string country)
        {
            Country = country;
        }

        public override bool isSelected(Film film)
        {
            return film.Country == Country;
        }
    }

    public class CategoryHelper : Helper
    {
        private string Category;

        public CategoryHelper(string category)
        {
            Category = category;
        }

        public override bool isSelected(Film film)
        {
            return film.Category == Category;
        }
    }

    public class RatingHelper : Helper
    {
        private float Rating;

        public RatingHelper(float rating)
        {
            Rating = rating;
        }

        public override bool isSelected(Film film)
        {
            return film.Rating >= Rating;
        }
    }
}
