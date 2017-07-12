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

            Console.WriteLine("What kind of foods do you like?:");
            string food = Console.ReadLine().ToUpper();
            Console.WriteLine("Name a second food that you like:");
            string food2 = Console.ReadLine().ToUpper();
            Console.WriteLine("Name your third favorite food:");
            string food3 = Console.ReadLine().ToUpper();
            string foodChoice = (food == "CHICKEN" && food2 == "SHRIMP" && food3 == "MEAT") ? "Good choice" : "Meh";
            Console.WriteLine(foodChoice.ToUpper());
            Console.ReadKey();

        }
    }
}
