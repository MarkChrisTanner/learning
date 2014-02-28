using System;
using System.Linq;
class LinqDemo1
{
  static void Main()
  {
    int[] numbers = { 6, 4, 2, 1, 8, 3, 7, 5, 2, 0 };
    const int CUTOFF = 3;
    var highNums =
        from x in numbers
        where x > CUTOFF
        select x;

    Console.WriteLine("Numbers > " + CUTOFF);
    foreach (var n in highNums)
    {
        Console.Write("{0}  ", n);
    }
    Console.WriteLine();
  }
}
