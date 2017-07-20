using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BADASS CALC 99");
            int firstNum;
            int secondNum;
            string end;
            string oper;
            int operNumb;

            do
            {
                Console.WriteLine("Enter first nubmer:");
                string firstNumber = Console.ReadLine();
                int.TryParse(firstNumber, out firstNum);
                Console.WriteLine("What operation would you like to perform?\n 1 - adding?\n 2 - subtraction?\n 3 - multiplication?\n 4 - division?");
                oper = Console.ReadLine();
                int.TryParse(oper, out operNumb);
                Console.WriteLine($"Enter a second number:");
                string secondNumber = Console.ReadLine();
                int.TryParse(secondNumber, out secondNum);
                while (!int.TryParse(firstNumber, out firstNum))
                {
                    Console.WriteLine($"You entered invalid value of {firstNumber}!\nPlease enter a first number:");
                    firstNumber = Console.ReadLine();
                    int.TryParse(firstNumber, out firstNum);
                }
                while ((!int.TryParse(oper, out operNumb) && operNumb > 4 && operNumb < 1) || !int.TryParse(oper, out operNumb) || operNumb > 4 || operNumb < 1)
                {
                    Console.WriteLine("You chose wrogn operation!\nWhat operation would you like to perform?\n 1 - adding?\n 2 - subtraction?\n 3 - multiplication?\n 4 - division?");
                    oper = Console.ReadLine();
                    int.TryParse(oper, out operNumb);
                }
                while (!int.TryParse(secondNumber, out secondNum))
                {
                    Console.WriteLine($"You entered invalid value of {secondNumber}!\nPlease enter second number:");
                    secondNumber = Console.ReadLine();
                    int.TryParse(secondNumber, out secondNum);

                }
                
                if (operNumb == 1)
                {
                    int add = Adding(firstNum, secondNum);
                    Console.WriteLine($"{firstNum} + {secondNum} = {add} ");
                }
                else if (operNumb == 2)
                {
                    int sub = Subs(firstNum, secondNum);
                    Console.WriteLine($"{firstNum} - {secondNum} = {sub}");
                }
                else if (operNumb == 3)
                {
                    int mul = Mult(firstNum, secondNum);
                    Console.WriteLine($"{firstNum} * {secondNum} = {mul}");
                }
                else if (operNumb == 4)
                {
                    if (secondNum == 0)
                    {
                        Console.WriteLine($"Division by {secondNum} is impossible!");
                    }
                    else if (firstNum % secondNum != 0)
                    {
                        int remainder = Rem(firstNum, secondNum);
                        int div = Divis(firstNum, secondNum);
                        Console.WriteLine($"{firstNum} : {secondNum} = {div} with a remainder of {remainder} ");
                    }
                    else
                    {
                        int div = Divis(firstNum, secondNum);
                        Console.WriteLine($"{firstNum} : {secondNum} = {div}");
                    }
                }



                Console.WriteLine("Press Enter or type YES to continue or NO to end to exit:");
                end = Console.ReadLine().ToLower();

            } while (end != "no" || end != "n");

            Console.WriteLine("Bye");
            Console.ReadKey();

        }
        public static int Adding(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
        public static int Subs(int firstNum, int secondNum)
        {
            return firstNum - secondNum;
        }
        public static int Mult(int firstNum, int secondNum)
        {
            return firstNum * secondNum;
        }
        public static int Divis(int firstNum, int secondNum)
        {
            return firstNum / secondNum;
        }
        public static int Rem(int firstNumb, int secondNum)
        {
            return firstNumb % secondNum;
        }
    }
}
