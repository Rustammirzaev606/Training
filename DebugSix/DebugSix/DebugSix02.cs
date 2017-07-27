// Program averages four numbers
using static System.Console;
class DebugSix02
{
   public static void SixTwo()
   {
      int[] numbers = {12, 15, 22, 88};
      int x;
      double average;
      double total = 0;
      WriteLine("The numbers are...");
        for (x = 0; x < numbers.Length; ++x)
        {
            Write("{0} ", numbers[x]);
        }
      WriteLine();      
      for(x = 0; x < numbers.Length; ++x)
      {
         total += numbers[x];
      }   
      average = total / numbers.Length;
      Write($"The average is {average}");
   }
}