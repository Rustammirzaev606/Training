using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For those who do not know: FizzBuzz is a quite popular childrens game. Counting from 1 to 100, and every time a number is divisible by 3 calling Fizz, every time a number is divisible by 5 calling Buzz and every time a number is divisible by 3 and 5, calling FizzBuzz instead of the number");
            int i = 1;
            string fb ;
            for (i = 1; i <= 100; ++i)
            {
                
                
                while ((i % 3) == 0 && (i % 5) != 0)
                {
                    fb = "FIZZ";
                }
                while ((i % 3) !=0 && (i % 5) == 0)
                {
                    fb = "BUZZ";
                }
                while ((i % 3) == 0 && (i % 5) == 0)
                {
                    fb = "FIZZ BUZZ";
                }
                while (((i % 3) != 0 || (i % 5) != 5) || ((i % 3) != 0 && (i % 5) != 0))
                {
                    fb = Convert.ToString(i);
                    

                }
                Console.WriteLine(fb);


                Console.ReadKey();
            }
        }
    }
}
