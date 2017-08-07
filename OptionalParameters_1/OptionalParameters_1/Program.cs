using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace OptionalParameters_1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"Using 2 arguments here!!!");
            DisplaySize(2, 4 );
            WriteLine($"Using 3 arguments now!!!");
            DisplaySize(1, 2, 3 );


        }
        public static void DisplaySize(int length, int width, int heigh = 4)
        {
            int area = length * width * heigh;
            Console.WriteLine($"{length} * {width} * {heigh} = {area}");
            ReadLine();



        }


    }
}
