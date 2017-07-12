using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernanryOperation2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Quiz!");
            Console.WriteLine("Who is the GREATEST NBA Play-offs player?:");
            string q1 = Console.ReadLine().ToUpper();
            string a1 = (q1 == "LEBRON" || q1 == "LEBRON JAMES" || q1 == "JAMES") ? "yes" : "no";
            Console.WriteLine("What is his number?:");
            string q2 = Console.ReadLine();
            string a2 = (q2 == "23" || q2 == "TWENTY THREE") ? "yes" : "no";
            string result = (a1 == "yes" && a2 == "yes") ? "AW YISS, LeBron James plays under the 23rd number" : "We dont like GSW here!";
            Console.WriteLine(result);
            Console.ReadKey();
            
        }
    }
}
