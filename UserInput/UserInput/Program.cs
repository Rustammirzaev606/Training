using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + " How are you today.");
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            Console.WriteLine("You are and {0} old guy.", age);
            Console.WriteLine(" {0} you are an {1} year old guy am i right.", name, age);
            Console.ReadLine();
            Console.WriteLine("Are you going out tonight?");
            
            string goingOut = Console.ReadLine();
            // string interpolation
            Console.WriteLine($"My name is {name} . I am {age} and {goingOut} of course.");
            Console.ReadLine();
        }
    }
}
