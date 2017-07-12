using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else_Practice4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give me a secong number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 < num2)
            {
                Console.WriteLine($"Number {num1} is less than {num2}");
            }
            else if (num1 > num2)
            {
                Console.WriteLine($"Number {num1} is greater than {num2}");
            }
            else
            {
                Console.WriteLine($"Number {num1} is equal to {num2}");
            }



            Console.ReadKey();
        }
    }
}
