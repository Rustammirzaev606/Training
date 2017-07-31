using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRestaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            PapaJohns pa = new PapaJohns();
            pa.Sauce = "Tomato";
            pa.Pork1 = "Chicken";
            pa.Veg1 = "Green pepper";
            pa.PrintToppings();

            PizzaHut ph = new PizzaHut();
            ph.Sauce = "Marinara";
            ph.Meat1 = "Ground Beef";
            ph.Bread1 = "Stuffed Crust";
            ph.PrintToppings();

            Console.ReadLine();    
        }
    }
}
