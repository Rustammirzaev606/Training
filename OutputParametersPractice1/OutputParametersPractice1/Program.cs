using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputParametersPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 0, second = 0;
            Program p = new Program();
            Console.WriteLine($"The initial value of first is {first}\nThe initial value of second is {second}");
            p.FindValues( out first,out second);
            Console.WriteLine($"The final value of first is {first}\nThe final value of second is {second}");
            Console.ReadLine();

        }

        private void FindValues(out int firsNum, out int secondNum)
        {
            int x, y;
            Console.WriteLine($"Give me a first # to work with");
            string firstNum1 = Console.ReadLine();
            int.TryParse(firstNum1, out firsNum);
            Console.WriteLine($"Give me a second # to work with");
            string secondNum2 = Console.ReadLine();
            int.TryParse(secondNum2, out secondNum);

            //firsNum += secondNum;
            //secondNum *= firsNum;
            x = firsNum + secondNum;
            y = firsNum * secondNum;
            firsNum = x;
            secondNum = y;
            Console.WriteLine($"The sum of first and number is {firsNum}\nThe product of first and second is {secondNum}");



        }




    }
}
