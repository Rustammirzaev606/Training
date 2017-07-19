using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int sentinel = rng.Next(0, 101);
            int total = 0;
            int inputCheck;
            int count = 0;
            
            
            Console.WriteLine($"Enter sentinel score between 0 and 100:");
            string input = Console.ReadLine();
            int.TryParse(input, out inputCheck);
            total += inputCheck;
            count++;
            if (inputCheck != sentinel)
            {



                while (inputCheck != sentinel)
                {
                    Console.WriteLine("WRONG! Try again:");
                    input = Console.ReadLine();
                    int.TryParse(input, out inputCheck);



                    total += inputCheck;
                    count++;
                }
            }
            else
            {
                Console.WriteLine("Bruh u broke it!");
            }
            
                Console.WriteLine($"CORRECT!{inputCheck}!");
            
            int avTotal = total / count;
            //Console.WriteLine($"Total is  {total}, count is {count}, average is {avTotal}");
            Console.WriteLine($"Total numbers entered: {count}. Total values entered: {total}. Average value entered: {avTotal}");
            Console.ReadLine();
           
        }
    }
}
