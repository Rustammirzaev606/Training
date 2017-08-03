using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDestructorPractice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test(55);
            
            
            Console.WriteLine("We are in the main method now!!");
            
            Console.WriteLine("I know where are you!!!");
            Test bruh = new Test(55);
            t.Bruh();
            Console.ReadLine();
            
        }
        
    }
}
