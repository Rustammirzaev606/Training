// Program displays every possible ID number for a company
// ID number is a letter, followed by a two-digit number
// For example -- A00 or Z99
// Go to a new display line after every 20 IDs
using static System.Console;
class DebugFive3
{
   public void bug3()
   {
      char letter = 'A';
      int number = 0;      
      const int NUMINROW = 20;
      //const int LOW = 0;
      //const int HIGH = 99;
      while (letter <= 'Z')
      {           
            if (number % NUMINROW == 0)
            {
                WriteLine();
            }
            Write($"{letter}{number.ToString("D2")} ");
            number++;
            if (number == 100)
            {
                number = 0;
                ++letter;
            }
      }
        //for (letter = 'A'; letter <= 'Z'; ++letter)
        //{
        //    for (number = LOW; number <= HIGH; ++number)
        //    {
        //        if (number % NUMINROW == 0)
        //        {
        //            WriteLine();
        //        }
        //        Write("{0}{1} ", letter, number.ToString("D2"));

        //    }
        //}
        ReadLine();
   }
}

