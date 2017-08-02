using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice1
{
    class Program
    {
        public interface IWork
        {
            void Printing();
            void Display();


        }
        public interface IClean
        {
            void Shop();



        }
        public class Names : IWork, IClean
        {
            string coder = "nice";

            public void Printing()
            {

                Console.WriteLine("I love Lucy");
            }
            public void Display()
            {
                Console.WriteLine("We are in the Display method");
            }
            public void Shop()
            {
                Console.WriteLine("shopping shmopping");
            }

            
        }


        static void Main(string[] args)
        {
            Names memes = new Names();
            memes.Display();
            memes.Printing();
            memes.Shop();

            Console.ReadLine();
        }

        public interface IRun
        {
            void Sprint();
        }
    }
}
