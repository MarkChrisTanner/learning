using System;
class DivisionBasedOnMajor
{
   enum Major
   {
      ACCOUNTING = 1, CIS, ENGLISH, MATH, MARKETING
   }
   static void Main()
   {
      int major;
      String message;
      Console.Write("Enter major code >> ");
      major = Convert.ToInt32(Console.ReadLine());
      switch ((Major) major)
      {
         case Major.ACCOUNTING:
         case Major.CIS:
         case Major.MARKETING:
            message = "Major is in the Business Division";
            break;
         case Major.ENGLISH:
         case Major.MATH:
            message = "Major is in the Humanities Division";
            break;
         default:
            message = "Department number is invalid";
            break;
      }
      Console.WriteLine(message);
   }
}
