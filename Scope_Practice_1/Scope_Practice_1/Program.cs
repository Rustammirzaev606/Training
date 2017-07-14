using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope_Practice_1
{
    public class Start
    {



    }

    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 1;
            int number2 = 2;
            int sum2 = Printing(number1, number2);
            int sum = number1 * number2;
            Console.WriteLine($"The {number1} * {number2} is not equal {sum}.");
            Console.WriteLine($"The sum of {number1} and {number2} is {sum2}");
            Console.ReadKey();
            




        }
        public static int Printing(int number1, int number2)
        {
            return number1 + number2;
            


        }
    }
}
