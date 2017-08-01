using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//i.Steps to complete
//⦁	Add a Square class with the following member variables & methods:
//a.  (length & width) Both types are doubles
//b.AcceptDetails()
//c.getArea()
//d.Display

namespace InheritanceHomeWork
{
    class Square : Shape
    {
        public double GetArea()
        {
            return (length * width);
        }

        public void Display()
        {
            Console.WriteLine($"The area of Square with heigth = {length} and length = {width} is {GetArea()}");
        }
        


    }
}
