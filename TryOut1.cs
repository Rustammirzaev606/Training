using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber, secondNumber;
            string userName;
            Console.WriteLine("Enter your name:");
            userName = Console.ReadLine();
            Console.WriteLine($"Welcone {userName}!");
            Console.WriteLine("Now give me a number:");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now give me another number:");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is " + $"{firstNumber + secondNumber}.");
            Console.WriteLine($"The result of substracting {firstNumber} and {secondNumber} is " + $"{firstNumber - secondNumber}.");
            Console.WriteLine($"The product of {firstNumber} and {secondNumber} is " +  $"{firstNumber * secondNumber}." );
            Console.WriteLine($"The result of dividing {firstNumber} and {secondNumber} is " + $"{firstNumber * secondNumber}.");
            Console.WriteLine($"The remainder after dividing {firstNumber} by " + $"{secondNumber} is {firstNumber % secondNumber}.");
            Console.ReadKey();


        }
    }
}
