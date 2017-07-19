using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop_Practice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int rngNum = rng.Next(1, 11);
            int guessNum;
            Console.WriteLine($"Guess a number between 1 and 10:");
            string numGuess = Console.ReadLine();
            int.TryParse(numGuess, out guessNum);
            int nomOfGuess = 1;

            while ( guessNum != rngNum )
            
            {
                               
                
                //if (guessNum == rngNum)
                
                //{

                //    Console.WriteLine("Correct!");
                //}
                //else 
                if ((guessNum < 1 && guessNum > 10) || (guessNum < 1) || (guessNum > 10))
                {
                    Console.WriteLine("Your guess should be between 1 and 10. Try Again!");

                }
                else
                {
                    Console.WriteLine("Wrong guess. Try again!");
                }
                
                numGuess = Console.ReadLine();
                int.TryParse(numGuess, out guessNum);


                nomOfGuess++;
            }


            Console.WriteLine($"CORRECT!\nYour guess number {guessNum} was CORRECT! You guessed {nomOfGuess} times");
            Console.ReadKey();




        }
    }
}
