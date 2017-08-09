using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hardware mouse = new Hardware();
            mouse.ID = 1234;
            mouse.Name = "Rival";
            mouse.Quantity = 1;
            mouse.Price = 49.99;
            mouse.Available = true;

            Hardware keyboard = new Hardware();
            keyboard.ID = 2345;
            keyboard.Name = "Razer";
            keyboard.Quantity = 1;
            keyboard.Price = 119.99;

            Hardware monitor = new Hardware();
            monitor.ID = 3456;
            monitor.Name = "Sceptre";
            monitor.Quantity = 1;
            monitor.Price = 99.99;
            monitor.Available = true;

            Hardware headset = new Hardware();
            headset.ID = 4567;
            headset.Name = "Void";
            headset.Quantity = 1;
            headset.Price = 59.99;

            Hardware mousepad = new Hardware();
            mousepad.ID = 5678;
            mousepad.Name = "Rival";
            mousepad.Quantity = 1;
            mousepad.Price = 59.99;
            mousepad.Available = true;

            Dictionary<int, Hardware> hwDict = new Dictionary<int, Hardware>();
            hwDict.Add(mouse.ID, mouse);
            hwDict.Add(keyboard.ID, keyboard);
            hwDict.Add(monitor.ID, monitor);
            hwDict.Add(headset.ID, headset);
            hwDict.Add(mousepad.ID, mousepad);

            foreach (KeyValuePair<int, Hardware> item in hwDict)
            {
                Hardware loop = item.Value;
                loop.PrintHardware();
                
            }
            Console.ReadLine();
            foreach (var item in hwDict)
            {
                Hardware loop = item.Value;
                if (loop.ID == 2345)
                {
                    loop.PrintHardware();
                }
            }
            Console.ReadLine();
        }
    }
}
