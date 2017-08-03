using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDestructorPractice_1
{
    class Test
    {
        //this is a constructor below... same name as the class itself

        private double length;

        public Test(double l)
        {
            double x = l + 5;
            Console.WriteLine("This is the constructor talking now!");
            Console.WriteLine(x);
        }

        public void Bruh()
        {
            Console.WriteLine("MIC CHECK");

        }
        ~Test()
        {
            System.Diagnostics.Trace.WriteLine("We are cleaning up our mess now!");
        }
    }
}
