using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHomeWork
{
    class Octagon : Shape
    {
        
        public double GetArea()
        {
            //return (high * length * 0.5);
            return (2 * (1 + Math.Sqrt(2)) * Math.Pow(length, 2));
        }

        public void Display()
        {
            Console.WriteLine($"The area of Octagon with a length {length} is {GetArea()}.");
        }

    }
} 
