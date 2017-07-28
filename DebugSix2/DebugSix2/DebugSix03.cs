// Finds whether a book dealer carries a requested book
using System;
using static System.Console;
class DebugSix03
{
   public static void SixThree()
   {
      string[] books = {"CATCH-22", "HARRY POTTER",
         "PROGRAMING USING C#", "RICH DAD, POOR DAD",
         "THE DEEP", "WIZARD OF OZ"};
      int x;
      string entryString;
      Write("What book are you looking for? ");
      
      entryString = Console.ReadLine().ToUpper();
        
      
        x = Array.BinarySearch(books, entryString);
        //Console.WriteLine(x);

        if (x < 0)
        {
            WriteLine("{0} not found", entryString);
        }
        else
        {
            WriteLine("Yes, we carry {0}", entryString);
        }
   }
}
