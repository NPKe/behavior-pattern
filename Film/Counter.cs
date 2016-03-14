using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FimlCount
{
    public class Counter
    {

        public int Count(Film[] a, int n, string country, string category, float rating)
        {
            int count = 0;

            MaxRating = FindMaxRating(a, n);

            for (int i = 0; i < n; i++)
            {
                if (isMatch(a[i], country, category, rating))
                        count++;
            }

            return count;
        }

        protected virtual bool isMatch(Film f, string country, string category, float rating)
        {
            return true;
        }

        protected float MaxRating;

        protected float FindMaxRating(Film[] a, int n)
        {
            float maxRating = a[0].Rating;

            for (int i = 1; i < n; i++)
                if (a[i].Rating > maxRating)
                    maxRating = a[i].Rating;

            return maxRating;
        }
    }
}
