using System;
class LocalVariableDemo
{
   static void Main()
   {
      int a = 12;
      Console.WriteLine("In Main() a is {0}", a);
      MethodWithItsOwnA();
      Console.WriteLine("In Main() a is {0}", a);
   }
   private static void MethodWithItsOwnA()
   {
      int a = 354;
      Console.WriteLine("In method a is {0}", a);
   }
}
