using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*5. a. Write a C# program named MilesToFeet that declares a named constant that
holds the number of feet in a mile: 5280. Also declare a variable to represent the
distance in miles between your house and your uncle’s house. Assign an
appropriate value to the variable—for example, 8.5. Compute and display the
distance to your uncle’s house in both miles and feet. Display explanatory text
with the values—for example, The distance to my uncle’s house is 8.5 miles or
44880 feet.
b. Convert the MilesToFeet class to an interactive application named
MilesToFeetInteractive. Instead of assigning a value to the distance, accept
the value from the user as input. */


namespace MilesToFeet
{
    class Program
    {
        static void Main(string[] args)
        {   
 
            const int mile = 5280; // miles in feet
 
            double uncleHouse;
  
            string userEnter;
 
            Console.Write("How many miles is it to your house? ");
 
            userEnter = Console.ReadLine();

            uncleHouse = Convert.ToDouble(userEnter);

 
            double uncleFeet = (mile * uncleHouse);


        //Console.WriteLine(uncleFeet);
         // Console.WriteLine(uncleHouse);
            //Console.WriteLine("the thing costs {0}, really {1}, {0} ", money, value);
        Console.WriteLine();
        Console.WriteLine("It is {0} miles or if you prefer {1} feet.", uncleHouse, uncleFeet );
        Console.WriteLine();
        Console.WriteLine("Now go away or I will taunt you a second time");
        Console.WriteLine();
        }
    }
}
