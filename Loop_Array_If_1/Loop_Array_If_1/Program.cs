using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Array_If_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int d = 0;
            int[] pieces = { 33, 51, 22, 78, 90 };
            for( d = 0 ; d < pieces.Length; ++d )
            {
                if(pieces[d] == 51)
                {
                    Console.WriteLine($"We found 51");
                    break;
                }
                Console.WriteLine(pieces[d]);

                Console.ReadKey();



            }
            Console.ReadKey();

            string[] cars = { "Buick", "Datsun", "BMW", "Chevy", "Corvette", "Olds" };
            for ( int e = 0; e  < cars.Length; ++e)
            {
                Console.WriteLine($"The value of the pieces array is currently {cars[e]}");
                if (cars[e] == "Corvette")
                {
                    Console.WriteLine($"We found the Vette");
                    break;

                }
                Console.ReadKey();
            }

            int newPiece = 0;
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            foreach (int piece in pieces)
            {
                newPiece += piece;
                
            }
            Console.WriteLine(newPiece);


                Console.ReadKey();


        }
    }
}
