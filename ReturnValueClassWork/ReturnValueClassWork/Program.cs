using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnValueClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string rest = "Chipotle";
            string favFodd = "Burritos";
            string full = FavRestaurant(rest, favFodd);
            Console.WriteLine(full);
            Console.ReadLine();
        }

        private static string FavRestaurant(string eatery, string goodies)
        {
            string bestMeal = eatery + " " + goodies;
            return bestMeal;
        }
    }
}
