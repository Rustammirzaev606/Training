using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut_Chapter4_
{
    enum orientation : byte
    {
        north = 1,
        south = 2,
        east = 3,
        west = 4

    }
    class Program
    {
        static void Main(string[] args)
        {
            orientation myDirection = orientation.north;
            byte directionByte;
            string directionString;
            Console.WriteLine($"myDirection = {myDirection}");
            directionByte = (byte)myDirection;
            directionString = Convert.ToString(myDirection);
            Console.WriteLine($"byte equivalent = {directionByte}");
            Console.WriteLine($"string equivalent = {directionString}");
            Console.ReadKey();

        }
    }
}
