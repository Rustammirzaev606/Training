using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    class BaseClass
    {
        public string Name { get; set; }
        public int ID { get; set; }     
        public double Price { get; set; }
        public double Subtotal { get; set; }
        public bool Discount { get; set; } = false;
        public double DiscountRate { get; set; }
        public double Savings { get; set; }
        public double NewPrice { get; set; }


        
    }
}
