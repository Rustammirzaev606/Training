using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers1
{
    class Memes
    {
        Program p = new Program();

        public void Genre()
        {
            int x = 1, y = 2;
            Program.TotalNumber(x, y);
            Console.WriteLine("Horror");
            Console.WriteLine("Action");
            Console.WriteLine(Program.DivideNumber(4, 2));
            Console.ReadLine();
            

        }
        
    }
}
