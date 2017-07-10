using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            //amusement park, when did you last time been there?, did u have fun?
            Console.WriteLine("What's your favorite amusement park? ");
            string parkName = Console.ReadLine();
            Console.WriteLine("When did you last time been there?(Type number of months)");
            string lastTime = Console.ReadLine();
            Console.WriteLine("Did you have fun?");
            string fun = Console.ReadLine();
                    
            Console.WriteLine($"Your favorite amusement park is {parkName}, last time you've been there {lastTime} month ago and {fun}, you had a lot of fun. ");
            Console.ReadKey();
        }
    }
}
