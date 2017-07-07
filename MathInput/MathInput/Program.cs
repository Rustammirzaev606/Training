using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MathInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the first # to add");
            string firstNum = Console.ReadLine();

            Console.WriteLine("Give me the second # you want to add");
            string secondNum = Console.ReadLine();
            //concatilation
            int x = Convert.ToInt32(firstNum);
            int y = Convert.ToInt32(secondNum);
            int sum = x + y;
            Console.WriteLine($"Your first number was {firstNum} and your second number was {secondNum}, the sum is {sum}.");








        }
    }
}
