using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4TryItOut_Arrays_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friendNames = { "Todd Anthony", "Kevin Holton", "Shane Laigle" };
            int i;
            Console.WriteLine($"Here are {friendNames.Length} of my friends:");
            for (i = 0; i < friendNames.Length; i++) 
            {
                Console.WriteLine($"{friendNames[i]}");
            }
            Console.ReadKey();
        }
    }
}
