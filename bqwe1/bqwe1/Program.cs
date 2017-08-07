// How much money will you have
//// after 30 days if you get a penny on the
//// first day and it doubles every day?
//using System;
//using static System.Console;
//class DebugFive4
//{
//    static void Main()
//    {
//        const double LIMIT = 1000000.00;
//        const double START = 0.01;
//        string inputString;
//        double total;
//        int howMany;
//        int count;
//        Write("How many days do you think ");
//        WriteLine("it will take you to reach");
//        Write("{0} starting with {1}", LIMIT.ToString("C"), START.ToString("C"));
//        WriteLine("and doubling it every day?");
//        inputString = ReadLine();
//        howMany = Convert.ToInt32(inputString);
//        count = 0;
//        total = START;
//        while (total != LIMIT)
//        {
//            total = total * 2;
//            count = count + 1;
//        }
//        if (howMany >= count)
//            WriteLine("Your guess was too high.");
//        else
//          if (howMany <= count)
//            WriteLine("Your guess was too low.");
//        else
//            WriteLine("Your guess was correct.");
//        WriteLine("It takes {0} days to reach {1}",
//           count, LIMIT.ToString("C"));
////        WriteLine("when you double {0} every day",
////           START.ToString("C"));
////        Console.ReadLine();
//    }
//}
// Program displays every possible ID number for a company
// ID number is a letter, followed by a two-digit number
// For example -- A00 or Z99
// Go to a new display line after every 20 IDs
//using static System.Console;
//class DebugFive3
//{
//    static void Main()
//    {
//        char letter;
//        int number = 0;
//        const int LOW = 0;
//        const int HIGH = 99;
//        const int NUMINROW = 20;
//        for (letter = 'A'; letter <= 'Z'; ++number)
//        {
//            //for (number = LOW; number > HIGH; ++number)
//            //{
//            if (number % NUMINROW == 0)
//            {
//                WriteLine();
//            }
//            if (number == 100)
//            {
//                ++letter;
//                number = 0;
//            }
//            if (letter > 'Z' )
//            {
//                break;
//            }
//            Write("{0}{1} ", letter, number.ToString("D2"));
//            //}

//        }
//        ReadLine();
//    }
//}
// Program displays every possible ID number for a company
// ID number is a letter, followed by a two-digit number
// For example -- A00 or Z99
// Go to a new display line after every 20 IDs
using static System.Console;
class DebugFive3
{
    static void Main()
    {
        char letter;
        int number;
        const int LOW = 0;
        const int HIGH = 99;
        const int NUMINROW = 20;
        for (letter = 'A'; letter <= 'Z'; ++letter)
        {
            for (number = LOW; number <= HIGH; ++number)
            {
                if (number % NUMINROW == 0)
                {
                    WriteLine();
                }
                Write("{0}{1} ", letter, number.ToString("D2"));
                
            }
        }
        ReadLine();
    }
}
