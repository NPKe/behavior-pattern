using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FimlCount
{
    class CountByCountry : Counter
    {
        protected override bool isMatch(Film f, string country, string category, float rating)
        {
            return f.Country == country;
        }
    }
}
