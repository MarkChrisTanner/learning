// Overloaded method gives bonus points
// whether grade is a number or letter
using System;
class DebugEight2
{
   static void Main()
   {
      int numericScore = 82;
      string letterScore = B;
      Console.Write("Score was {0}. ", numericScore);
      GiveBonus(ref numericScore);
      Console.WriteLine("Now it is {0}.", numericScore);
      Console.Write("Grade was ", letterScore);
      GiveBonus(ref letterScore);
      Console.WriteLine("Now it is ", letterScore);
   }
   private static void GiveBonus(int ref testScore)
   {
      const int BONUS = 5;
      testScore = BONUS;
   }
   private static void GiveBonus(string ref letterScore)
   {
      const string BONUS = "+";
      letterScore = BONUS;
   }
}

