using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugFive
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DebugFive1 buggy1 = new DebugFive1();
            buggy1.bug1();
            DebugFive2 buggy2 = new DebugFive2();
            buggy2.bug2();
            DebugFive3 buggy3 = new DebugFive3();
            buggy3.bug3();
            DebugFive4 buggy4 = new DebugFive4();
            buggy4.bug4();
            Console.ReadKey();
        }
    }
}
