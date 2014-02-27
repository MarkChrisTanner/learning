// This program greets the user
// and multiplies two entered values
using System;
class DebugTwo2
{
    static void Main()
    {
        string name;
        string firstString, secondString;
        int first, second, product;
        Console.WriteLine("Enter your name");
        name = Console.ReadLine();
        Console.WriteLine("Hello {0}! Enter an integer", name);
        first = Console.ReadLine();
        Console.WriteLine("Enter another integer");
        second = Console.ReadLine();

        product = first * second;
        Console.WriteLine("Thank you {1}. The product of {2} and {3} is {4}",
       name, first, second, product);
    }
}
