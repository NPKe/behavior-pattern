using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FimlCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Film[] film = new Film[5];

            film[0] = new Film("Teo em", "Vietnam", "Hai huoc", 7);
            film[1] = new Film("Doremon", "Japan", "Thieu nhi", 8);
            film[2] = new Film("Deadpool", "US", "Hai huoc", 7);
            film[3] = new Film("De mai tinh", "Vietnam", "Thieu nhi", 6);
            film[4] = new Film("Em la ba noi cua anh", "Vietnam", "Hai huoc", 8);

            Counter counter;

            counter = new CountByCountry();
            Console.WriteLine(counter.Count(film, 5, "Vietnam", "", 0));

            counter = new CountByCategory();
            Console.WriteLine(counter.Count(film, 5, "", "Thieu nhi", 0));

            counter = new CountByRating();
            Console.WriteLine(counter.Count(film, 5, "", "", 7));

            counter = new CountByRatingAndCategory();
            Console.WriteLine(counter.Count(film, 5, "", "Hai huoc", 7));

            counter = new CountMaxRating();
            Console.WriteLine(counter.Count(film, 5, "", "", 0));
        }
    }
}
