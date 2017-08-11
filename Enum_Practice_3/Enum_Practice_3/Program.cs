using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Practice_3
{
    
    enum Car
    {
        
        Toyota = 1,
        Honda,
        Infinity,
        BMW
    }
    class Program
    {
        

        static void Main(string[] args)
        {
            int buyCar;
            Console.WriteLine("We are selling these cars:\n 1. Toyota\n 2. Honda\n 3. Infinity\n 4. BMW");
            string choiceCar = Console.ReadLine();
            int.TryParse(choiceCar, out buyCar);
            switch((Car)buyCar)
            {
                case Car.Toyota:
                    Toyota();
                    break;
                case Car.Honda:
                    Honda();
                    break;
                case Car.Infinity:
                    Infinity();
                    break;
                case Car.BMW:
                    BMW();
                    break;
                default:
                    Console.WriteLine("Good Luck catching that bus!");
                    Console.ReadKey();
                    break;
            }
            
        }
        public static void Toyota()
        {
            Console.WriteLine("Aww you little asian guy!");
            Console.ReadKey();
        }
        public static void Honda()
        {
            Console.WriteLine("You are still a little asian guy!");
            Console.ReadKey();

        }
        public static void Infinity()
        {
            Console.WriteLine("Make sure you have enough money!");
            Console.ReadKey();
        }
        public static void BMW()
        {
            Console.WriteLine("Since you have money we will double charge you!");
            Console.ReadKey();

        }
            
    }
}
