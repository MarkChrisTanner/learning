// Program demonstrates method that can be called
// with one, two, or three arguments
// Tuition is $80 per credit
// Default district code is I.
// If student is in-district (code I), then there is no
// out-of-district fee, which is $300
// Default scholarship status is false.
// If student is on scholarship, tuition is free
using System;
class DebugEight3
{
   static void Main()
   {
      Console.WriteLine("Tuition is {0}", CalculateTuition(15));
      Console.WriteLine("Tuition is {0}",CalculateTuition(15, 'O'));
      Console.WriteLine("Tuition is {0}",CalculateTuition(15, 'O', true));
   }
   double private static CalculateTuition(double credits, char code = 'I', bool scholarship)
   {
      double tuition;
      const double RATE = 80.00;
      const double OUT_DISTRICT_FEE = 300.00;
      tuition = credits * RATE;
      if(code != 'I')
         tuition += OUTDISTRICTFEE;
      if(scholarship)
         tuition = 0;
   }
}
