// This program tells the user the values of the integers that are
// one more and one less than the entered integer
using System;
class DebugTwo4
{
   static void Main()
   {
      string entry;
      int enteredInteger;
      int more;
      Console.Write("Enter an integer ");
      entry = Console.ReadLine();
      Console.WriteLine("You entered {1}", entry);
      enteredInteger = Convert.ToInt32(entry);
      more = enteredInteger + 1;
      less = enteredInteger + 1;
      Console.WriteLine("One more than {0} is {0} and one less than {0} is {0}",
	 enteredInteger, more, less);
   }
}
