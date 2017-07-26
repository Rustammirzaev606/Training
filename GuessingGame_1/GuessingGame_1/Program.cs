using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int realNum;
            int rNum = rng.Next(1, 6);
            Console.WriteLine($"Enter a number between 1 and 6:");
            string numGuess = Console.ReadLine();

            int.TryParse(numGuess, out realNum);
            while (realNum != rNum)
            //while ( realNum < 0 || realNum > 6)
            {
                Console.WriteLine($"Your guess of {numGuess} was not correct\n Guess again!");
                numGuess = Console.ReadLine();
                int.TryParse(numGuess, out realNum);
                //rNum = rng.Next(1, 4);

            }
            Console.WriteLine($"Your guess of {numGuess} was correct...Hooray!");
            Console.ReadLine();
            //string x;
            //double t, s = 1;
            //int count = 0;

            //Console.WriteLine("Enter some numbers: ");
            //Console.WriteLine("To finish, press Enter");
            //while ((x = Console.ReadLine()) != "")
            //{
            //    t = Convert.ToDouble(x);
            //    s *= t;
            //    count++;
            //}
            //Console.WriteLine("The result is: {0}", s);
            //Console.WriteLine("The count is: {0}", count);
            //Console.ReadLine();
        }
    }
}
