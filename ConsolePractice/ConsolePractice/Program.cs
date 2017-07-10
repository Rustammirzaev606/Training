using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //string dude = Console.ReadLine();

            //Console.WriteLine($"My name is {dude}");
            //Console.ReadKey();
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}! How old are you?");
            string age = Console.ReadLine();
            string ageComparison;
            if (Convert.ToInt32(age) < 20)
            {

                ageComparison = "teenager";
            }
            else if (Convert.ToInt32(age) > 20 && Convert.ToInt32(age) < 55)

            {
                ageComparison = "young man";
            }

            else
            {
                ageComparison = "grandpa";
            }
            Console.WriteLine($"Hi {name}. You are {age} years old {ageComparison}.");

            Console.ReadKey();
        }  
    }
}

