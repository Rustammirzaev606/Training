// Program prompts user for any number of values 
// (up to 20)
// and averages them
using System;
using static System.Console;
class DebugSix04
{
    public static void SixFOur()
    {
        
        const int QUIT = 999;
        int[] numbers = new int[20];
        int x = 0;
        int num;
        double average;
        double total = 0;
        string inString;
        Console.Write("Please enter a number or " +
           QUIT + " to quit...");
        inString = ReadLine();
        //num = Convert.ToInt32(inString);
        int.TryParse(inString, out num);
        while ((x < numbers.Length) && num != QUIT)
        {
            numbers[x] = num;
            total += numbers[x];
            ++x;
            Write("Please enter a number or " +
               QUIT + " to quit...");
            inString = ReadLine();
            num = Convert.ToInt32(inString);
            //int.TryParse(inString, out num);
        }
        WriteLine("The numbers are:");
        for (int y = 0; y < x; ++y)
            Console.Write("{0,6}", numbers[y]);
        average = total / x;
        WriteLine();
        WriteLine("The average is {0}", average);
        Console.ReadLine();
    }
}