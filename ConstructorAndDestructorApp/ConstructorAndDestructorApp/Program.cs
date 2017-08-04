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

            Console.ReadLine();
        }
    }
}
