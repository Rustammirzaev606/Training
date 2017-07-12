using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6_TryItOut_Page122
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string text = "";
            for (i = 0; i < 10; i++) 
            {
                text = "Line" + Convert.ToString(i);
                Console.WriteLine($"{text}");

            }
            Console.WriteLine($"Last text output in loop: {text}");
            Console.ReadKey();
        }
    }
}
