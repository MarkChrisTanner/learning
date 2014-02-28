// Program averages four numbers
using System;
class DebugSix02
{
   static void Main()
   {
      int[] numbers = {12, 15, 22, 88};
      int x;
      double average;
      double total = 0;
      Console.Write("\nThe numbers are...");
      for(x = 0; x < numbers.Length; ++x)
         Console.Write("{0, 6}", nmbers[x]);
      Console.WriteLine();      
      for(x = 0; x < numbers.Length; ++x)
      {
         total = numbers[x];
      }   
      average = total / numbers.length;
      Console.Write("The average is {0}");
   }
}