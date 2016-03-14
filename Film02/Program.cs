using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film02
{
    class Program
    {
        static void Main(string[] args)
        {
            Film[] film = new Film[5];

            film[0] = new Film("Teo em", "Vietnam", "Hai huoc", 7);
            film[1] = new Film("Doremon", "Japan", "Thieu nhi", 9);
            film[2] = new Film("Deadpool", "US", "Hai huoc", 7);
            film[3] = new Film("De mai tinh", "Vietnam", "Thieu nhi", 6);
            film[4] = new Film("Em la ba noi cua anh", "Vietnam", "Hai huoc", 8);

            Counter counter = new Counter();
            Console.WriteLine(counter.Count(film, 5));

            counter.ratingHelper = new RatingHelper(counter.GetMaxRating(film, 5));
            Console.WriteLine(counter.Count(film, 5));


            counter.categoryHelper = new CategoryHelper("Thieu nhi");
            Console.WriteLine(counter.Count(film, 5));


            counter.countryHelper = new CountryHelper("Vietnam");
            Console.WriteLine(counter.Count(film, 5));


        }
    }
}
