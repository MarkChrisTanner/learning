using System;
class FourHellos
{
   static void Main()
   {
      int number = 1;
      const int LIMIT = 5;
      while(number < LIMIT)
      {
         Console.WriteLine("Hello");
         number = number + 1;
      }
   }
}
