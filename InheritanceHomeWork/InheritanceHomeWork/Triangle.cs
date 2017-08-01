using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHomeWork
{
    class Triangle : Shape
    { 
        public double GetArea()
        {
            return (0.5 * length * high);
        }

        public void Display()
        {
            Console.WriteLine($"The area of Triangle with Lengh = {length} and Heigth = {high} is {GetArea()}");
        }
    }
}
