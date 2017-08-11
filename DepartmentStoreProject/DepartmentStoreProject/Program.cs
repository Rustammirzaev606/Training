using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentStoreProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Hats qwe = new Hats();
            Dictionary<int, Hats> zxc = new Dictionary<int, Hats>();
            foreach (KeyValuePair<int, Hats> item in zxc)
            {
                Console.WriteLine(item.Value);

            }



        }
        public void CallShoes()
        {


            //need to be filled
        }
        public void CallPants()
        {

            //need to be filled

        }
        public void CallShirts()
        {
            //need to be filled


        }






        //public void CallHats()
        //{
        //    //need to be filled
        //    Hats name1 = new Hats();
        //    name1.ID = 1;
        //    name1.Name = "Baseball cap";
        //    name1.Price = 39.99;

        //    Hats name2 = new Hats();
        //    name2.ID = 2;
        //    name2.Name = "name2";
        //    name2.Price = 19.99;
        //}
        
        

    }
    
    
}
