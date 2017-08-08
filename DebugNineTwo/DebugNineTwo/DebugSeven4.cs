// Program calls a method that finds and returns
// the median value in an array
// The median value is the middle value from largest to smallest
// If there are an even number of values, the
// median is the mean of the two middle values
using System;
using static System.Console;
class DebugSeven4
{
   public void SevenFour()
   {
      int[] firstArray = {10, 9, 2, 3, 5, 6}; //5+6=11   11/2=5.5
      int[] secondArray = { 112, 456, 782 }; // 456!!
      int[] thirdArray = {9, 12, 45, 82, 84, 67, 2, 6}; //12+45=57 57/2=28.5
      WriteLine("The median value of the first array is {0}",
         FindMedian(firstArray));
      WriteLine("The median value of the second array is {0}",
         FindMedian(secondArray));
      WriteLine("The median value of the third array is {0}",
         FindMedian(thirdArray));
   }
   private static double FindMedian(int[] array)
   {
      double median;
      int middle = (array.Length / 2); // = 3        
      Array.Sort(array);
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }

        if (array.Length % 2 == 0)
        { median = (double)(array[middle - 1] + array[middle]) / 2; } 
                                        // 2   +     3  /  5
        // 8 items, 0 to 7 index, 82 + 84,
        else
        { median = array[middle]; }
      return median;
   }
}
