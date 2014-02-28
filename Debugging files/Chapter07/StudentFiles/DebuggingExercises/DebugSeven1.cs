// Uses DisplayWebAddress method three times
using System;
class DebugSeven1
{
   static void Main()
   {
      DisplayWebAddress;
      Console.WriteLine("Shop at Shopper's World");
      DisplayWebAddress;
      Console.WriteLine("The best bargains from around the world");
      DisplayWebAddress;
   }
   private void DisplayWebAddress()
   {
      Console.WriteLine("------------------------------");
      Console.WriteLine("Visit us on the web at:");
      Console.WriteLine("www.shoppersworldbargains.com");
      Console.WriteLine("******************************");
   }
}
