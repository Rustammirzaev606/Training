﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Chapter4TryItOut
{
    class Program
    {
        static void Main(string[] args)
        {
            string comparison;
            WriteLine("Enter a number:");
            double var1 = Convert.ToDouble (ReadLine());
            WriteLine("Enter another number:");
            double var2 = Convert.ToDouble(ReadLine());
            if (var1 < var2)
           
                comparison = "less than";
            
            else
            {
                if (var1 == var2)
                    comparison = "equal to";
                else
                    comparison = "greater than";

            }
            WriteLine($"The first number is {comparison} the second number.");
            ReadKey();
        }
    }
}
