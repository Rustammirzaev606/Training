using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentStoreProject
{
    class Hats : Basic
    {
        public bool Discount { get; set; } = false;
        public void CallHats()
        {
            //need to be filled
            Hats name1 = new Hats();
            name1.ID = 1;
            name1.Name = "Baseball cap";
            name1.Price = 39.99;

            Hats name2 = new Hats();
            name2.ID = 2;
            name2.Name = "name2";
            name2.Price = 19.99;
        }
    }    
}
