using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise4._2_p73_
{
    class Program
    {
        static void Main(string[] args)
        {
            string comparison;
            Console.WriteLine("Enter two values. One of them MUST be less than 10. The other one MUST be greater than 10");
            Console.WriteLine("Enter a value for var1");
            int var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value for var2");
            int var2 = Convert.ToInt32(Console.ReadLine());
            if (var1 > 10 && var2 > 10)
                Console.WriteLine("Wrong number buddie!");
            
            else
            {
                if (var1 > 10)
                    comparison = $"{var1} is greater than 10!";
                else
                {
                    if (var2 > 10)
                        comparison = $"{var2} is greater than 10!";
                    else

                        comparison = $"both {var1} and {var2} are less than 10!";

                }


            }
            Console.WriteLine($"{comparison}");

            Console.ReadKey();
        }
    }
}
