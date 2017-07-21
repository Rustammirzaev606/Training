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
            double firstNum;
            double secondNum;
            string end;
            string oper;
            int operNumb;

            do
            {
                Console.WriteLine("Enter first nubmer:");
                string firstNumber = Console.ReadLine();
                double.TryParse(firstNumber, out firstNum);
                while (!double.TryParse(firstNumber, out firstNum))
                {
                    Console.WriteLine($"You entered invalid value for first number!\nPlease enter a first number:");
                    firstNumber = Console.ReadLine();
                    double.TryParse(firstNumber, out firstNum);
                }
                Console.WriteLine("What operation would you like to perform?\n 1 - adding?\n 2 - subtraction?\n 3 - multiplication?\n 4 - division?");

                oper = Console.ReadLine();
                int.TryParse(oper, out operNumb);
                while ((!int.TryParse(oper, out operNumb) && operNumb > 4 && operNumb < 1) || !int.TryParse(oper, out operNumb) || operNumb > 4 || operNumb < 1)
                {
                    Console.WriteLine("You chose wrong operation!\nWhat operation would you like to perform?\n 1 - adding?\n 2 - subtraction?\n 3 - multiplication?\n 4 - division?");
                    oper = Console.ReadLine();
                    int.TryParse(oper, out operNumb);
                }
                Console.WriteLine($"Enter a second number:");
                string secondNumber = Console.ReadLine();
                double.TryParse(secondNumber, out secondNum);
                while (!double.TryParse(secondNumber, out secondNum))
                {
                    Console.WriteLine($"You entered invalid value for second number!\nPlease enter second number:");
                    secondNumber = Console.ReadLine();
                    double.TryParse(secondNumber, out secondNum);

                }
                //while (!int.TryParse(firstNumber, out firstNum))
                //{
                //    Console.WriteLine($"You entered invalid value for first number!\nPlease enter a first number:");
                //    firstNumber = Console.ReadLine();
                //    int.TryParse(firstNumber, out firstNum);
                //}
                //while ((!int.TryParse(oper, out operNumb) && operNumb > 4 && operNumb < 1) || !int.TryParse(oper, out operNumb) || operNumb > 4 || operNumb < 1)
                //{
                //    Console.WriteLine("You chose wrogn operation!\nWhat operation would you like to perform?\n 1 - adding?\n 2 - subtraction?\n 3 - multiplication?\n 4 - division?");
                //    oper = Console.ReadLine();
                //    int.TryParse(oper, out operNumb);
                //}
                //while (!int.TryParse(secondNumber, out secondNum))
                //{
                //    Console.WriteLine($"You entered invalid value for second number!\nPlease enter second number:");
                //    secondNumber = Console.ReadLine();
                //    int.TryParse(secondNumber, out secondNum);

                //}
                
                if (operNumb == 1)
                {
                    double add = Adding(firstNum, secondNum);
                    Console.WriteLine($"{firstNum} + {secondNum} = {add} ");
                }
                else if (operNumb == 2)
                {
                    double sub = Subs(firstNum, secondNum);
                    Console.WriteLine($"{firstNum} - {secondNum} = {sub}");
                }
                else if (operNumb == 3)
                {
                    double mul = Mult(firstNum, secondNum);
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
                        double remainder = Rem(firstNum, secondNum);
                        double div = Divis(firstNum, secondNum);
                        Console.WriteLine($"{firstNum} : {secondNum} = {div} with a remainder of {remainder} ");
                    }
                    else
                    {
                        double div = Divis(firstNum, secondNum);
                        Console.WriteLine($"{firstNum} : {secondNum} = {div}");
                    }
                }



                Console.WriteLine("Press Enter or type YES to continue or NO to end to exit:");
                end = Console.ReadLine().ToLower();

            } while (end != "no" || end != "n");

            Console.WriteLine("Bye");
            Console.ReadKey();

        }
        public static double Adding(double firstNum, double secondNum)
        {
            return firstNum + secondNum;
        }
        public static double Subs(double firstNum, double secondNum)
        {
            return firstNum - secondNum;
        }
        public static double Mult(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }
        public static double Divis(double firstNum, double secondNum)
        {
            return firstNum / secondNum;
        }
        public static double Rem(double firstNumb, double secondNum)
        {
            return firstNumb % secondNum;
        }
    }
}
