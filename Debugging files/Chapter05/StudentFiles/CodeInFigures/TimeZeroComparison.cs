using System;
using System.Diagnostics;
class TimeZeroComparison
{
   static void Main()
   {
      int LOOPS = 10000000;
      Stopwatch sw = Stopwatch.StartNew();
      for(int x = 0; x < LOOPS; ++x);
      sw.Stop();
      Stopwatch sw2 = Stopwatch.StartNew();
      for(int x = LOOPS; x >= 0; --x);
      sw2.Stop();
      Console.WriteLine("Time used comparing to {0}: {1} ms",
         LOOPS, sw.Elapsed.TotalMilliseconds);
      Console.WriteLine("Time used comparing to 0       : {0} ms",
         sw2.Elapsed.TotalMilliseconds);
   }
}
