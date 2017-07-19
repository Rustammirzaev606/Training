using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhilePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int randNum = r.Next(1, 10);
            int guessNum;
            int Numofguesses = 1;

            Console.WriteLine("Guess a number between 1 and 10");
            do
            {
                string actualnum = Console.ReadLine();
                while (!int.TryParse(actualnum, out guessNum) || guessNum < 1 || guessNum > 10)
                {
                    Console.WriteLine($"You entry of {guessNum} is out of bounds \n try again");
                    actualnum = Console.ReadLine();

                    Numofguesses++;
                }
                if (randNum == guessNum)
                {
                    Console.WriteLine($"YOur guess of {randNum}was correct you guess {Numofguesses} of times");

                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine($" your guess of {guessNum} was not correct");
                    Numofguesses++;
                }

            } while (guessNum != randNum);
        }
    }
}