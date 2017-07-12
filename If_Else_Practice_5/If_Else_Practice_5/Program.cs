using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;
   
namespace If_Else_Practice_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MilkyWay costs $1.20.\n Make a payment:");
            double payment = Convert.ToDouble(Console.ReadLine());
            double cost = 1.20;
            double change;
            if (payment < cost)
            {
                change = cost - payment;
                Console.WriteLine($"Add ${change} to complete the purchase!:");
            }
            else if ( payment == cost)
            {
                change = 0.00;
                Console.WriteLine($"Your payment is ${payment} and ${change} change. Enjoy!");

            }
            else if ( payment <= 5)
            {
                change = payment - cost;
                Console.WriteLine($"Your payment is ${payment} and ${change} change. Enjoy!");
            }
           
            else
            {
                change = payment;
                Console.WriteLine($"ERROR. We DO NOT accept bills greater than $5. Your change is ${change}");
                
            }


            Console.ReadKey();



        }
    }
}
