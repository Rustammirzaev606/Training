// Uses DisplayWebAddress method three times
using static System.Console;
class DebugSeven1
{
   public static void SevenOne()
   {
        DebugSeven1 x = new DebugSeven1();
        x.DisplayWebAddress();
      
      WriteLine("Shop at Shopper's World");
        x.DisplayWebAddress();
        WriteLine("The best bargains from around the world");
        x.DisplayWebAddress();
    }
   private void DisplayWebAddress()
   {
      WriteLine("------------------------------");
      WriteLine("Visit us on the web at:");
      WriteLine("www.shoppersworldbargains.com");
      WriteLine("******************************");
   }
}
