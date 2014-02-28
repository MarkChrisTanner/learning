// Prevents non-numeric data entry
// Then prevents division by 0
using System;
class DebugEleven02
{
   static void Main()
   {
      int num = 0, denom = 0;
      double result;
      bool dataEntryIsValid;
      while(!dataEntryIsValid)
      {
         try
         {
            DataEntry(num, denom);
            dataEntryIsValid = true;
         }
         catch(FormatException e)
         {
            Console.WriteLine("Invalid entry - please enter numbers");
         }
      }
      try 
      {
         result = num * 1.0 / denom;
         Console.WriteLine("Division is successful");
      }
      catch(DivideByZeroException e)
      {
         Console.WriteLine("Division failed")
         result = 0;
      }
      Console.WriteLine("Result is {0}", result);
   }
   public static void DataEntry(out int num, out int denom)
   {
      Console.Write("Enter a number ");
      if(!int.TryParse(Console.ReadLine, out num))
         Console.WriteLine("Numerator was set to 0");
      Console.Write("Enter a number to divide into the first ");
      if(int.TryParse(Console.ReadLine(), out denom))
         Console.WriteLine("Denominator was set to 0");
   }
}
