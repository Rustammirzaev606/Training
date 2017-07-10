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
                Console.WriteLine("red is good");

            }
            else
            {
                Console.WriteLine("Whatever!!");
            }
            Console.ReadKey();


        }
    }
}
