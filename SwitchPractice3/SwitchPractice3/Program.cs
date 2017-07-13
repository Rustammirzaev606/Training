using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchPractice3
{
    class Program
    {
        static void Main(string[] args)
        {
            int triParse;
            Console.WriteLine("Welcome to NASTY Vendor Machine!\n We have:\n 1 - StarBucks Coffee:\n 2 - Gatorade Energy Drink:\n 3 - Bottle of Water:\n What would you like?:");
            string drink = Console.ReadLine();
            int.TryParse(drink, out triParse);
            switch (triParse)
            {
                case 1:
                    Console.WriteLine("StarBucks Coffee is on the way. HOLD ON!");
                    break;
                case 2:
                    Console.WriteLine("Gatorade is on the way. HOLD ON!");
                    break;
                case 3:
                    Console.WriteLine("Water is on the way. HOLD ON!");
                    break;
                default:
                    Console.WriteLine("Wrong Input!");
                    break;

            }
            Console.ReadKey();

            Console.WriteLine("Do you like chicken?");
            string chicken = Console.ReadLine().ToUpper();
            switch (chicken)
            {
                case "YES":
                    Console.WriteLine("Great, I like chiken too!");
                    break;
                case "NO":
                    Console.WriteLine("No? Why? Chicken is great!");
                    break;
                default:
                    Console.WriteLine("Mmmm... KFC grill chicken...");
                    break;
            }
            Console.ReadKey();







        }
    }
}
