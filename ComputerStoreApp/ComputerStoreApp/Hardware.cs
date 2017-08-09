using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStoreApp
{
    class Hardware
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public bool Available { get; set; } = false;

        public void PrintHardware()
        {
            Console.WriteLine($"Item: {Name}, quantity = {Quantity}, price = {Price}, available: {Available}.");
        }

    }
}
