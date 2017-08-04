using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAndDestructorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string uno = "Rustam", dos = "Mirzaev";
            
            Professor pr = new Professor(uno, dos);
            pr.Display();
            pr.SecreNumbes(12, 13);
            Professor pr1 = new Professor(22, 33);
            Student bruh = new Student();
            bruh.DipslayNumb();

            Console.ReadLine();
        }
    }
}
