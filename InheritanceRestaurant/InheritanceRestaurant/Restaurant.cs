using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRestaurant
{
    public class Restaurant
    {
        public string Sauce, Pork1, Pork2, Veg1, Veg2;


        public virtual void PrintToppings()
        {
            Console.WriteLine($"Your pizza has {Sauce} + {Pork1} and {Veg1}");



        }

    }
}
