using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Shoes slippers = new Shoes();
            slippers.ShoesID = 9999;
            slippers.Size = 8;
            slippers.Color = "Army Mesh";
            slippers.Price = 19.99;
            slippers.Available = true;
            slippers.Name = "SLIPPERS";

            Shoes boots = new Shoes();
            boots.ShoesID = 8888;
            boots.Size = 12;
            boots.Color = "Brown";
            boots.Price = 59.99;
            boots.Name = "BOOTS";

            Shoes oxfords = new Shoes();
            oxfords.ShoesID = 7777;
            oxfords.Size = 10;
            oxfords.Color = "Black";
            oxfords.Price = 199.99;
            oxfords.Name = "OXFORDS";

            List<Shoes> ShoesInTheStore = new List<Shoes>();
            ShoesInTheStore.Add(slippers);
            ShoesInTheStore.Add(boots);
            ShoesInTheStore.Add(oxfords);

            Console.WriteLine("We checked list of items for availability:");

            foreach (Shoes item in ShoesInTheStore)
            {

                Console.WriteLine($"Item : {item.Name}, with ID:{item.ShoesID}, size: {item.Size}, color: {item.Color}, price: {item.Price} is available = {item.Available}! ");

            }            
            Console.WriteLine("\nHere is a list of unavailable items:\n");

            ShoesInTheStore.Remove(slippers);

            //if (slippers.Available == true)
            //{
            //    ShoesInTheStore.Remove(slippers);
            //}

            foreach (Shoes item in ShoesInTheStore)
            {
                if (item.Available == false)
                {
                    Console.WriteLine($"Item : {item.Name}, with ID:{item.ShoesID}, size: {item.Size}, color: {item.Color}, price: {item.Price} is available = {item.Available}! ");
                }
                
                //Console.WriteLine($"Item : {item.Name}, with ID:{item.ShoesID}, size: {item.Size}, color: {item.Color}, price: {item.Price} is available = {item.Available}! ");

            }
            


            Console.ReadLine();



        }
    }
}
