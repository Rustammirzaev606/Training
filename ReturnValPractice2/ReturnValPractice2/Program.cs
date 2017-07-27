using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnValPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine($"You like {Food()} and your Date of Birth is {DoB()}");
            Console.ReadLine();
        }
        static string Food()
        {
            Console.WriteLine("What is your favorite food?");
            string favFood = Console.ReadLine().ToLower();
            Console.WriteLine($"What is your favorite dish?");
            string favDish = Console.ReadLine().ToLower();
            return favFood + " " + favDish;
        }
        static double DoB()
        {
            double monthDoB;
            double dateDoB;
            double completeDage;
            string tempo1;
            string tempo2;
            string tempo3;

            do
            {
                Console.WriteLine("Enter your month of birth");
                tempo1 = Console.ReadLine().ToLower();
                if (tempo1 == "january")
                {
                    tempo1 = "1";
                }
                else if (tempo1 == "february")
                {
                    tempo1 = "2";
                }
                else if (tempo1 == "march")
                {
                    tempo1 = "3";
                }
                else if (tempo1 == "april")
                {
                    tempo1 = "4";
                }
                else if (tempo1 == "may")
                {
                    tempo1 = "5";
                }
                else if (tempo1 == "june")
                {
                    tempo1 = "6";
                }
                else if (tempo1 == "july")
                {
                    tempo1 = "7";
                }
                else if (tempo1 == "august")
                {
                    tempo1 = "8";
                }
                else if (tempo1 == "september")
                {
                    tempo1 = "9";
                }
                else if (tempo1 == "october")
                {
                    tempo1 = "10";
                }
                else if (tempo1 == "november")
                {
                    tempo1 = "11";
                }
                else if (tempo1 == "december")
                {
                    tempo1 = "12";
                }
                double.TryParse(tempo1, out monthDoB);

                while (!double.TryParse(tempo1, out monthDoB))
                {
                    Console.WriteLine("Wrong input.\nEnter your month of birth");
                    tempo1 = Console.ReadLine();
                }

                if (monthDoB > 12)
                {
                    while (monthDoB > 12)
                    {
                        Console.WriteLine("You kidding me right? Enter your month of birth!");
                        tempo1 = Console.ReadLine();
                    }
                }

                Console.WriteLine("And what is the date of your birth?");
                tempo2 = Console.ReadLine();
                double.TryParse(tempo2, out dateDoB);

                while (!double.TryParse(tempo2, out dateDoB))
                {
                    Console.WriteLine("Wrong input.\nEnter your date of birth");
                    tempo2 = Console.ReadLine();
                }

                if (dateDoB > 31)
                {
                    while (dateDoB > 31)
                    {
                        Console.WriteLine("You kidding me right? Enter your date of birth!");
                        tempo2 = Console.ReadLine();
                    }
                }

                tempo3 = monthDoB + "." + dateDoB;
                double.TryParse(tempo3, out completeDage);
            } while (!double.TryParse(tempo3, out completeDage));
            return completeDage;
        }
    }
}
