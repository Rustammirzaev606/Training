using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHomeWork
{
    class Shape
    {
        

        public void SetLength(double l = 1)
        {
            length = l;
        }

        public void SetWidth(double w = 1)
        {
            width = w;
        }

        public void SetHigh(double h = 1)
        {
            high = h;
        }

        
        protected double length, width, high;
    }
}
