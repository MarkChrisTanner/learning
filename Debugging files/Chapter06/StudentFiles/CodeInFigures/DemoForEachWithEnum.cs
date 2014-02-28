using System;
class DemoForEachWithEnum
{
   enum Day
   {
      SUNDAY, MONDAY, TUESDAY, WEDNESDAY,
        THURSDAY, FRIDAY, SATURDAY
   }
   static void Main()
   {
      foreach(string day in Enum.GetNames(typeof(Day)))
        Console.WriteLine(day);
   }
}


