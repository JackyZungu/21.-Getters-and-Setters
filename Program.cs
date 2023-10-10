using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Getters_and_Setters
{
     class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Titatic", "Jim", "PG-13");
            Movie movie2 = new Movie("Unreleased", "Jacky", "PG");

            Console.WriteLine(movie1.Rating);
            Console.ReadLine();
        }
    }
}
