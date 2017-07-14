using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Practice_1
{
    enum Movies
    {
        Jaws = 1 ,
        Goodfellas ,
        Heat ,
        Godfather ,
        Avatar,
        Inception,
        GetOut
    }
    enum Vendor
    {
        SomepuchinoCoffee = 1,
        MilkyWay,
        Shmandwich,
        Yougurt,
    }
    class Program
    {
        static void Main(string[] args)
        {
            int favMovie;
            Console.WriteLine($"Which movie is your favourite?\n 1. Jaws\n 2. Goodfells\n 3. Heat\n 4. Godfather\n 5. Avatar\n 6. Inception\n 7. GetOut");
            string favorite = Console.ReadLine();

            int.TryParse(favorite, out favMovie);
            switch ((Movies)favMovie)
            {
                case Movies.Avatar:
                    Console.WriteLine($"Avatar is an OK movie.");
                    break;
                case Movies.GetOut:
                    Console.WriteLine($"GetOut is an OK movie too.");
                    break;
                case Movies.Godfather:
                    Console.WriteLine($"Godfather is a great movie!");
                    break;
                case Movies.Heat:
                    Console.WriteLine($"I dont remeber that movie!");
                    break;
                case Movies.Inception:
                    Console.WriteLine($"A Christopher Nolan's movie!");
                    break;
                case Movies.Jaws:
                    Console.WriteLine($"Good choice!");
                    break;
                case Movies.Goodfellas:
                    Console.WriteLine($"A classic");
                    break;
                default:
                    Console.WriteLine($"Fast and Furious sux!");
                    break;
            }
            Console.ReadKey();
            int nastyVendor;
            Console.WriteLine($"\n Nasty vendor machine is back!\n 1. Somepuchino Coffee - $3.50\n 2. Milky Way - $1.20\n 3. Shmandwich - $1.50\n 4. Yogurt - $2.00");
            string preOrder = Console.ReadLine();
            int.TryParse(preOrder, out nastyVendor);
            
            switch((Vendor)nastyVendor)
            
            {
                case Vendor.MilkyWay:
                    Console.WriteLine("Milky Way is on the way!");
                    break;
                case Vendor.Shmandwich:
                    Console.WriteLine("Worst thing ever!");
                    break;
                case Vendor.SomepuchinoCoffee:
                    Console.WriteLine("Drugs at its finest!");
                    break;
                case Vendor.Yougurt:
                    Console.WriteLine("Good choice!");
                    break;
                default:
                    Console.WriteLine("HARD WORK = 49:1");
                    break;

            }
                

            
            Console.ReadKey();


        }
    }
}
