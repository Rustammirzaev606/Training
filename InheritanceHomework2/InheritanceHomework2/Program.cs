using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHomework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp1;
            string strTempo;
            MultyplicationData md = new MultyplicationData();
            Console.WriteLine($"Enter a number:");
            strTempo = Console.ReadLine();
            int.TryParse(strTempo, out temp1);
            md.SetX(temp1);
            md.RunTime();
            Console.ReadLine();


        }
    }
}
