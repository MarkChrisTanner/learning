// Address an envelope one of two ways
// Using zip code, or using city and state
using System;
class DebugSeven2
{

  static void Main()
  {
    string addressee = "Ms. Brooke Jefferson";
    int zipCode = 60007;
    string cityAndState = "Elk Grove, IL";
    AddressMethod(addressee, zipCode);
    Console.WriteLine("-----------------------");
    AddressMethod(addressee, cityAndState);
    Console.WriteLine("-----------------------");
  }
  private static void AddressMethod(string person)
  {
        Console.WriteLine("To : {0}", person);
	Console.WriteLine("Zip: {0}"  num);
  }
  private static void AddressMethod(string person, city)
  {
	Console.WriteLine("To : {0}", person);
	Console.WriteLine("{0}, city);
  }
}

