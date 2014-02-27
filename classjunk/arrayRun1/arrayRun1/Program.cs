using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayRun1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] number = new int[10];

            for (int counter = 0; counter < 10; counter++)
            {
                number[counter] = r.Next(20);
            }

            for (int counter = 0; counter < 10; counter++)
            {
                int arrayPosition = (counter + 1);
                Console.Write("The {0} in the array is ", arrayPosition);
                Console.WriteLine(number[counter]);
            }
            Array.Reverse(number);
            Console.WriteLine();
            Console.WriteLine("Now in reverse!");
            Console.WriteLine();

            for (int counter = 0; counter < 10; counter++)
            {
                int arrayPosition = (counter + 1);
                Console.Write("The {0} in the array is ", arrayPosition);
                Console.WriteLine(number[counter]);
            }
            
            Console.WriteLine();
            Console.Write("now to double reverse");
            Console.WriteLine();

            for (int counter = 9; counter >= 0; counter--)
            {
                int arrayPosition = (counter + 1);
                Console.Write("The {0} in the array is ", arrayPosition);
                Console.WriteLine(number[counter]);
            }
        }
    }
}
