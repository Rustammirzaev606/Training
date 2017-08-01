using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPracticeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car donkey = new Car();
            donkey.DisplayEngineFormula();
            Console.WriteLine(donkey.DisplayEngineFormula());
            Console.ReadLine();
        }
    }
}
