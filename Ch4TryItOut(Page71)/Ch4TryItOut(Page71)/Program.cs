using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4TryItOut_Page71_
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //for (i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}




            //int i = 1;
            //while ( i <= 10)
            //{
            //    if (i == 9)
            //        break;
            //    Console.WriteLine($"{i++}");
            //}



            //int i = 1;
            //for(i = 1; i <= 10; i++)
            //{
            //    if ((i % 2) == 0)
            //        continue;
            //    Console.WriteLine(i);

            //}


            int i;
            for ( i = 1; i <= 10; i++)
            {
                if ((i % 2) == 0)
                    continue;
                Console.WriteLine(i);

            
            }
            //Console does not checks if (i % 2) equals 0 but states instead. The "==" sign is assigned for checking it. 
        






            Console.ReadKey();
        }
    }
}
// break
            // continue
            // return