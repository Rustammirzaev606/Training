using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHomework2
{
    class MultyplicationData
    {
        public void SetX(int y)
        {
            x = y;
        }
        public void RunTime()
        {
            
            for (int y = 1; y <= 10; y++)
            {
                Console.WriteLine($"{x} * {y} = {x * y}");
            }
        }

        private double x;

        
    }
}
