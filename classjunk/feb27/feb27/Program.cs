using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feb27
{
    class Program
    {
        static void Main(string[] args)
        {
            //searching an array using a for loop with parallel arrays
            //parrallel arrays have values the corealate to values in the shared position
            //use a for loop and search the first array and then look into the second array at the second location.

            /*for (int x = 0; x < validValues.Lenght; ++x)
            {
                if(itemOrder == validValues[x])
                {
                    isValid Item = true;
                    itemPrice = prices[x];
                }
            }
            if (isValidItem)
                Console.WriteLine("Price is {0}", itemPrice);
            */

            int[] studentID = { 220000, 331056, 200001, 335099, 230546 };
            int x;
            string entryString;
            int entryID;
            Array.Sort(studentID);

            Console.Write("enter and ID number.  >>");
            entryString = Console.ReadLine();
            entryID = Convert.ToInt32(entryString);

            x = Array.BinarySearch(studentID, entryID);

            Console.WriteLine(x);



        }
    }
}
