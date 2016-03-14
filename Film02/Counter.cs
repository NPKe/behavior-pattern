using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film02
{
    public class Counter
    {
        public Helper countryHelper;
        public Helper categoryHelper;
        public Helper ratingHelper;


        public Counter()
        {
            countryHelper = new Helper();
            categoryHelper = new Helper();
            ratingHelper = new Helper();
        }

        public Counter(Helper country, Helper category, Helper rating)
        {
            countryHelper = country;
            categoryHelper = category;
            ratingHelper = rating;
        }

        public int Count(Film[] film, int n)
        {
            int count = 0;
            for (int i = 0; i < n;  i++)
                if (
                        countryHelper.isSelected(film[i])
                        && categoryHelper.isSelected(film[i])
                        && ratingHelper.isSelected(film[i])
                    )
                {
                    count++;
                }
            return count;
        }

        public float GetMaxRating(Film[] film, int n)
        {
            float maxRating = film[0].Rating;

            for (int i = 1; i < n; i++)
                if (film[i].Rating > maxRating)
                    maxRating = film[i].Rating;

            return maxRating;
        }
    }
}
