using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElsePractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite car?");
            string car = Console.ReadLine().ToUpper();

            if (car == "TOYOTA" || car == "HONDA")
            {
                Console.WriteLine("Asian Dude, wtf?");
            }
            else if (car == "BUICK")
            {
                Console.WriteLine("Dude, WTF?");
            }
            else if (car == "BMW" || car == "MERCEDES")
            {
                Console.WriteLine("My man");
            }
            else
            {
                Console.WriteLine("Whatever!!!");
            }
            Console.ReadKey();
        }
    }
}
