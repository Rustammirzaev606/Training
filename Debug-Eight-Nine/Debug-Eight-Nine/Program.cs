using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debug_Eight_Nine
{
    class Program
    {
        static void Main(string[] args)
        {
            DebugEight3 boogi = new DebugEight3();
            boogi.BugEightThree();

            DebugEight4 googie = new DebugEight4();
            googie.BugEightFour();

            DebugNine1 goofy = new DebugNine1();
            goofy.BugNine1();




            Console.ReadLine();
        }
    }
}
