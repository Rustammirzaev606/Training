using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice2
{
    class Program
    {
        public interface ILunch
        {
             void Lunch();
        }
        public interface IWantEat
        {
            void BlackBeanBurger();
        }
        public interface ISmoke
        {
            void WeedEveryDay();
        }

        public class Memes : ILunch, IWantEat, ISmoke
        {
            public void Lunch()
            {
                Console.WriteLine($"Lunch time!");
            }

            public void BlackBeanBurger()
            {
                Console.WriteLine($"Taking Black Bean Burger Combo!");
            }

            public void WeedEveryDay()
            {
                Console.WriteLine($"4.20");
            }
        }

        static void Main(string[] args)
        {
            Memes bruh = new Memes();
            bruh.Lunch();
            bruh.BlackBeanBurger();
            bruh.WeedEveryDay();
            Console.ReadLine();
        }
    }
    
}
