using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers1
{
     public class Program
    {
        static void Main(string[] args)
        {
            Memes bruh = new Memes();
            bruh.Genre();
            
            int number1 = 200;
            int number2 = 300;
            int complete = TotalNumber(number1, number2);
            Console.WriteLine(complete);
            Console.ReadLine();
            Console.WriteLine(DivideNumber(number1, number2));
            Console.ReadLine();
        }
        public static int TotalNumber(int x, int y)
        {
            return x + y;

        }
        private static int AddNUmber(int x, int y)
        {

            return x + y;
        }
        public static double DivideNumber(double x, double y)
        {



            return x / y;
        }
    }


}
