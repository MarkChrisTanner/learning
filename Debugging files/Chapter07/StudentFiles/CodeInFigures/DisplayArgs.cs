using System;
class DisplayArgs
{
   static void Main(string[] args)
   {
      for(int x = 0; x < args.Length; ++x)
         Console.WriteLine("Argument {0} is {1}", x, args[x]);
   }
}