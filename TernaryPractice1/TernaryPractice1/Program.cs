using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite sport?:");
            string sport = Console.ReadLine();
            string favSport = (sport == "soccer" || sport == "football" ) ? "Great choice" : "Bad choice";
            Console.WriteLine(favSport);
            Console.ReadKey();
        }
    }
}
