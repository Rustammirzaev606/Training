using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace ExceptionsPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            int milesDriven;
            int gallonsOfGas;
            int mpg;
            Program p = new Program();
            p.JewError();
            //try
            //{
            //    Console.WriteLine("Enter miles driven:");
            //    milesDriven = ToInt32(ReadLine());

            //    Console.WriteLine("Enter gallon of gas purchased:");
            //    gallonsOfGas = ToInt32(ReadLine());

            //    mpg = milesDriven / gallonsOfGas;


            //    WriteLine($"You are getting {mpg} miles per gallon ");
            //    ReadLine();
            //}
            //catch (Exception error)
            //{
            //    WriteLine(error.Message);
            //}

            Program.ArrayError();
            Console.ReadLine();

        }

        static void ArrayError()
        {
            try
            {
                int num = 12, denom = 0, result;
                int[] numArray = { 20, 30, 40 };
                result = num / denom;
            }
            catch (DivideByZeroException bro)
            {
                WriteLine(bro.Message);
            }
            catch (IndexOutOfRangeException bru)
            {
                WriteLine(bru.Message);
            }

        }
        public void JewError()
        {
            try
            {
                int firstNum = 20, seconNum = 0, answer;
                answer = firstNum / seconNum;
                
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.ToString());
            }
            finally
            {
                Console.ReadLine();
            }

        }
    } 
}
