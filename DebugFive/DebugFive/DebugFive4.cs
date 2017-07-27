// How much money will you have
// after 30 days if you get a penny on the
// first day and it doubles every day?
using System;
using static System.Console;
class DebugFive4
{
   public void bug4()
   {
      const double LIMIT = 1000000.00;
      const double START = 0.01;
      string inputString;
      double total;
      int howMany;
      int count;        
      WriteLine($"How many days do you think it will take you to reach {LIMIT.ToString("C")} starting with {START.ToString("C")} and doubling it every day ?");
      inputString = ReadLine();        
      int.TryParse(inputString, out howMany);
      count = 0;
      total = START;
      while (!(total >= LIMIT))
      {
         total *= 2;
         count = count + 1;
            
      }

        if (howMany >= count)
        {
            WriteLine("Your guess was too high.");
        }
        else if (howMany <= count)
        {
            WriteLine("Your guess was too low.");
        }
        else
        {
            WriteLine("Your guess was correct.");
        }
        WriteLine($"It takes {count} days to reach {LIMIT.ToString("C")} when you double {START.ToString("C")} every day! ");
        double x = 0.01;
        for (int i = 0; i < 30; i++)
        {
            x *=  2;
        }
        Console.WriteLine($"In 30 days we will have {x.ToString("C")}");
        Console.ReadKey();



   }
}

