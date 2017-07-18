using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop_Numbers_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int idNum;
            int lowNum = 1000;
            int highNum = 2000;

            Console.WriteLine($"Enter a valid ID NUmber");
            string valNum = Console.ReadLine();
            int.TryParse(valNum, out idNum);
            while (idNum <= lowNum || idNum >= highNum)
            {
                Console.WriteLine($"The ID number you entered {valNum} must be between {lowNum} and {highNum}.\n" + "Enter a new ID number:");
                valNum = Console.ReadLine();
                int.TryParse(valNum, out idNum);


            }
            Console.WriteLine($"Bazzinga!");
            Console.ReadKey();

        
        }
    }
}
