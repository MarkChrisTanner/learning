// Finds whether a book dealer carries a requested book
using System;
class DebugSix03
{
   static void Main()
   {
      String[] books = {"Catch-22", "Harry Potter",
         "Programming Using C#", "Rich Dad, Poor Dad",
         "The Deep", "Wizard of Oz"};
      int x;
      string entryString;
      Console.Write("What book are you looking for? ");
      entryString = Console.Readline();
      x = Array.BinarySearch(books);
      if(x < 0)
         Console.WriteLine("{0} not found", entry);
      else
         Console.WriteLine("Yes, we carry {0}", entry);   
   }
}
