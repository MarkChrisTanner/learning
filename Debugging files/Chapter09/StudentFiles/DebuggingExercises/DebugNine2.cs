// Creates a Breakfast class
// and instantiates an object
// Displays Breakfast special information
using System;
class FixedDebugNine2
{
   static void Main()
   {
      Breakfast special = new Breakfast("French toast, 4.99);
      //Display the info about breakfast
      Console.WriteLine(INFO);
      // then display today's special
      Console.WriteLine("Today we are having {0} for {1}",
         special.name, special.Price.ToString("C2"));
  }
}
class Breakfast
{
   public string INFO = 
      "Breakfast is the most important meal of the day.";
   private string name;
   private double Price;
   // Breakfast constructor requires a
   // name, e.g "French toast", and a price
   public Breakfast(string name, double price)
   {
       name = name;
       price = price;
   }
   public string Name {get; set}
   public double Price {get; set}
}