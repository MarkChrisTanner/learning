using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program named IntArrayDemo that stores an array of 10 integers.
Until the user enters a sentinel value, allow the user three options: (1) to view the
list in order from the first to last position, (2) to view the list in order from the
last to first position, or (3) to choose a specific position to view.
*/
namespace IntArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[10];
            string input;

            for (int counter = 0; counter < 10; counter++)
            {
                int position = counter + 1;
                Console.Write("Please enter a value for the {0} position ", position);
                number[counter] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine("Please make a selection to decide what how do see the information stored.");
            Console.WriteLine("1 will give the information sotred in the array in the order it is prestented.");
            Console.WriteLine("2 will give the order of the array in reverse order.");
            Console.WriteLine("3 will ask you to enter the number of the location and display that information stored in the array");
            Console.WriteLine();
            Console.Write("Make your choice. ");
            input = Convert.ToString(Console.ReadLine());

            switch (input)
            {
                case "1":
                    for (int counter = 0; counter < 10; counter++)
                    {
                        Console.WriteLine(number[counter]);
                    }
                    break;
                case "2":
                    for (int counter = 9; counter > 0; counter--)
                    {
                        Console.WriteLine(number[counter]);
                    }
                    break;
                case "3":
                    Console.Write("Enter the location in the aray that you wish to have. ");
                    int location = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine(number[location - 1]);
                    break;
                default:
                    Console.WriteLine("This will not end well.");
                    break;
            }
        }
    }
}

