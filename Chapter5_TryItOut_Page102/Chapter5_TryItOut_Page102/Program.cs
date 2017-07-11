using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5_TryItOut_Page102
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "blah blah dude was here huehuehue"; //declaring a string
            char[] separator = {' '};                              //a value that will be used to separate string
            string[] myWords;                                      // creating a string that will contain myString value after being separated
            myWords = myString.Split(separator);                   //giving a command to apply separator to myString
            foreach (string word in myWords)                       //
            {
                Console.WriteLine($"{word}");
            }


            string newString = "A string";                         //declaring newString with a value "A string"
            char[] myChars = newString.ToCharArray();              //taking every character from newString and putting into myChars array
            foreach (char newChars in myChars)                     //taking EACH character from myChars array and writing it on console
                {
                    Console.WriteLine($"{newChars}");
                }
            Console.ReadKey();

        }
    }
}
