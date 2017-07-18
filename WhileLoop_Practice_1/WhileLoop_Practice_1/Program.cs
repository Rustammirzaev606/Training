using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop_Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "bob";
            string password = "007";

            Console.WriteLine("What is your name?:");
            string inputName = Console.ReadLine().ToLower();
            Console.WriteLine("What is your password?:");
            string pw = Console.ReadLine();

            while ((inputName != userName) && ( pw != password))
            {
                Console.WriteLine($"The username and/or password was incorrect!");
                while (inputName != userName)
                {                    
                    Console.WriteLine($"The username was incorrect. Try again!");
                    inputName = Console.ReadLine().ToLower();

                }
                Console.WriteLine("Correct username!");
                while (pw != password)
                {
                    Console.WriteLine($"The password was incorrect. Try Again!");
                    pw = Console.ReadLine().ToLower();
                }
                Console.WriteLine("Correct password!");
                //Console.WriteLine($"The combination that you entered was not correct.");
                //Console.WriteLine("Try again.\n Enter username:");
                //inputName = Console.ReadLine().ToLower();
                //Console.WriteLine($"Enter password:");
                //pw = Console.ReadLine().ToLower();
                Console.WriteLine("Phew");
                                                
            }

            Console.WriteLine("That was the correct username and password... Hooray");
            Console.ReadKey();






        }
    }
}
