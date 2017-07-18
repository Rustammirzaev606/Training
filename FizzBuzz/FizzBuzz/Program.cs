using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For those who do not know: FizzBuzz is a quite popular childrens game. Counting from 1 to 100, and every time a number is divisible by 3 calling Fizz, every time a number is divisible by 5 calling Buzz and every time a number is divisible by 3 and 5, calling FizzBuzz instead of the number");
            int i = 1;
            for (i = 1; i <= 100; ++i) 
            {

                if ((i % 3) == 0 && (i % 5) != 0)
                {
                    Console.WriteLine($"Fizz");
                }
                else if ((i % 5) == 0  && (i % 3) != 0)
                {
                    Console.WriteLine($"Buzz");
                }
                else if ((i % 3) == 0 && (i % 5) == 0)
                {
                    Console.WriteLine($"FIZZ BUZZ!");


                }
                else
                {
                    Console.WriteLine(i);
                }
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
