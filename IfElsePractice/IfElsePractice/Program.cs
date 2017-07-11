using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElsePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite color");
            string favColor = Console.ReadLine().ToUpper();
            string blah = "nice";
            if (favColor == "RED") 
            {
                Console.WriteLine("We found a match!!!");


                Console.WriteLine($"red is {blah}");

            }
            else if(favColor == "BLUE")
            {
                Console.WriteLine($"{favColor} is good too.");
            }
            else
            {
                Console.WriteLine("We definitely did not find a match.");
                Console.WriteLine("Whatever!!");
            }
            Console.ReadKey();


        }
    }
}
