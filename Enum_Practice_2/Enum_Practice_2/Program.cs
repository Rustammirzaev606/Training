using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Practice_2
{
    enum Burger
    {
        Whopper = 1,
        BigMack,
        ChickenSandwich,
        Single
    }
    class Program
    {
        static void Main(string[] args)
        {
            int BChoice;
            Console.WriteLine("Which burger is your favorite\n 1. Whopper\n 2. Big Mac\n 3. Chicken Sandwich\n 4. Wendy's Single");
            string burgerChoice = Console.ReadLine();
            int.TryParse(burgerChoice, out BChoice);

            switch ((Burger)BChoice)
            {
                case Burger.Whopper:
                    //Console.WriteLine("I Like It Too!");
                    Bk();
                    break;
                case Burger.BigMack:
                    //Console.WriteLine("I dont know how it tastes.");
                    Mc();
                    break;
                case Burger.ChickenSandwich:
                    //Console.WriteLine("Mmmm, Chicken Sandwich!");
                    Kfc();
                    break;
                case Burger.Single:
                    //Console.WriteLine("I heard this are good!");
                    Wendys();
                    break;
                default:
                    //Console.WriteLine("Right, Better make your own, HEALTHY food!");
                    break;

            }
            Console.ReadKey();

        }

        public static void Wendys()
        {
            Console.WriteLine("Wendy's burgers are great");
            Console.ReadKey();
        }
        public static void Kfc()
        {
            Console.WriteLine("Mmmm, KFC sandwich!");
            Console.ReadLine();
        }
        public static void Bk()
        {
            Console.WriteLine("WHOPPER!");
            Console.ReadKey();
        }
        public static void Mc()
        {
            Console.WriteLine("MacSomewich");
            Console.ReadKey();
        }
    }
}
