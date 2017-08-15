using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    enum HatsEnum
    {
        BaseballCaps = 1,
        Fedoras,
        Boaters,
        Beanies,
        Homburg,
        TopHats
    }
    class HatsObjects : BaseClass
    {
        public double HatsSubtotal { get; set; }
        public void SomeHats(int Button)
        {
            HatsObjects BaseballCaps = new HatsObjects();
            BaseballCaps.ID = 1;            
            BaseballCaps.Price = 9.00;


            HatsObjects Fedoras = new HatsObjects();            
            Fedoras.ID = 2;         
            Fedoras.Price = 27.99;

            HatsObjects Boaters = new HatsObjects();            
            Boaters.ID = 3;            
            Boaters.Price = 40.00;

            HatsObjects Beanies = new HatsObjects();            
            Beanies.ID = 4;            
            Beanies.Price = 9.99;

            HatsObjects Homburg = new HatsObjects();            
            Homburg.ID = 5;            
            Homburg.Price = 43.95;

            HatsObjects TopHats = new HatsObjects();                       
            TopHats.ID = 6;            
            TopHats.DiscountRate = 0.15;

            //switch((HatsEnum)Button)
            //{
            //    case HatsEnum.BaseballCaps:
            //        Subtotal += BaseballCaps.Price;
            //        break;
            //    case HatsEnum.Beanies:
            //        Subtotal += Beanies.Price;
            //        break;
            //    case HatsEnum.Boaters:
            //        Subtotal += Boaters.Price;
            //        break;
            //    case HatsEnum.Fedoras:
            //        Subtotal += Fedoras.Price;
            //        break;
            //    case HatsEnum.Homburg:
            //        Subtotal += Homburg.Price;
            //        break;
            //    case HatsEnum.TopHats:
            //        Subtotal += TopHats.Price;
            //        break;
            //}
            if (Button == 1)
            {
                Subtotal += BaseballCaps.Price;
            }

        }
    }
}
