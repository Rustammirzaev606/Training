using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace If_Else_Practice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please enter your first name:");
            string firstName = Console.ReadLine().ToUpper();
            Console.WriteLine("Now enter your last name:");
            string lastName = Console.ReadLine().ToUpper();
            Console.WriteLine("And your age is?:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine($"Hi {firstName} {lastName}. You are a highschooler");

            }
            else if (age > 18 || age < 55)
            {
                Console.WriteLine($"Hello {firstName} {lastName}. How are you today?");
            }
            else
            {
                Console.WriteLine($"Hi old man {firstName} {lastName}");
            }
            Console.ReadKey();
            
        }
    }
}
