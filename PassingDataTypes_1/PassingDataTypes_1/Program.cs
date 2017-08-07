using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingDataTypes_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = { 1, 5, 12, 66, 27 };
            string[] memes = { "john cena", "SlamDunk", "Rickroll", "Turn down 4 Watt" };
            int i = 0;
            
            for (i = 0; i < 5; i++ )
            {
                Console.Write($"{arrayInt[i]} ");
                
            }
            Console.ReadKey();
            MaxArray(arrayInt);
            Console.ReadKey();
            DumbArray(memes);
        }
        public static void SumArray(int[] arrayVals)
        {

            
            Array.Sort(arrayVals);
            Console.WriteLine($"");

        }

        public static void MaxArray(int[] intArray)
        {
            int maxVal = intArray.Max();
            Console.WriteLine($"The maximum value of the array is {maxVal}");


        }

        public static void DumbArray(string[] Names)
        {
            /*string allNames = Names*/
            for (int k = 0; k < Names.Length; ++k)
            {
                Console.WriteLine($"The names of the ArrayNames array are {Names[k]}");
            }
            Console.ReadLine();


        }
    }
}
