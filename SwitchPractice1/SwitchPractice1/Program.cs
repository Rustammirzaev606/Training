using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchPractice1
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine().ToLower();
            int foodLike;
            //int meh = int.Parse

            int.TryParse(color, out foodLike);

            switch(foodLike)
            {
                case 5:
                    Console.WriteLine("Red is an ok Color");
                    break;;
                case 2:
                    Console.WriteLine("Blue is fine too");
                    break;
                default:
                    Console.WriteLine("We dont understand your answer");
                    break;
            }
            Console.ReadKey();




        }
    }
}
