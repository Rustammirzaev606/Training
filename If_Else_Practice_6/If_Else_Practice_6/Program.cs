using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace If_Else_Practice_6
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("What is your age?:");
            double firstNum = double.Parse(ReadLine());
            if (firstNum >= 1 && firstNum <= 10) 
            {
                WriteLine("You r just a kid LMAO");

            }
            else if (firstNum >= 11 && firstNum <= 20 )
            {
                WriteLine("You are in your middle years");
            }
            else if (firstNum >= 20 && firstNum <= 35)
            {
                WriteLine("You are getting there");
            }
            else if (firstNum >= 35 && firstNum <= 55)
            {
                WriteLine("You have it figured out by now");
            }
            else
            {
                WriteLine("you are in your golden years!!!");
            }
            ReadKey();




        }
    }
}
