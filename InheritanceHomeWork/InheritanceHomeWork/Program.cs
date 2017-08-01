using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//⦁	Exercises to be completed tonight and no later than Tuesday 8/1.
//a.RectangleApplication
//Add 3 more classes(Square, Triangle & Octogon) to your app
//i.Steps to complete
//⦁	Add a Square class with the following member variables & methods:
//a.  (length & width) Both types are doubles
//b.AcceptDetails()
//c.getArea()
//d.Display
//e.Add the remaining code to make this class provide the square root
//⦁	Add a Triangle class with the following member variables & methods:
//a.  (length & width) Both types are doubles
//b.AcceptDetails()
//c.getArea()
//d.Display
//e.Add the remaining code to make this class provide the square root
//⦁	Add an Octogon class with the following member variables & methods:
//a.  (length & width) Both types are doubles
//b.AcceptDetails()
//c.getArea()
//d.Display
//e.Add the remaining code to make this class provide the square root
//f.  *****BONUS***** (If complete with a.)


namespace InheritanceHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string tempo1, tempo2;
            double tempo3, tempo4;
            Octagon o = new Octagon();
            Triangle t = new Triangle();
            Square s = new Square();
            Console.WriteLine("To find area of square we need Heigth and Width\n Set a value for Square Heigh:");
            tempo1 = Console.ReadLine();
            double.TryParse(tempo1, out tempo3);
            s.SetLength(tempo3);
            Console.WriteLine("Set a value for Square Width:");
            tempo2 = Console.ReadLine();
            double.TryParse(tempo2, out tempo4);
            s.SetWidth(tempo4);
            s.Display();
            Console.ReadLine();

            Console.WriteLine("To find the area of triangle we need Length and Height\n Set a value for Triangle Length:");
            tempo1 = Console.ReadLine();
            double.TryParse(tempo1, out tempo3);
            t.SetLength(tempo3);
            Console.WriteLine("Set a value for Triangle Height:");
            tempo2 = Console.ReadLine();
            double.TryParse(tempo2, out tempo4);
            t.SetHigh(tempo4);
            t.Display();
            Console.ReadLine();

            Console.WriteLine("To find the area of Octagon we only need Length\n Set a value for Octogon Length:");
            tempo1 = Console.ReadLine();
            double.TryParse(tempo1, out tempo3);
            o.SetLength(tempo3);
            o.Display();
            Console.ReadLine();

            //No idiot-proofs cuz im lazy
        }
    }
}
