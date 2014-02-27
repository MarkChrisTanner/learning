using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feb25
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring and creating an array
            double[] sales;
            sales = new double[20];

            //off by 1. arrays count from the number 0
            //assigning a value to an array element
            sales[0] = 2100.00;
            Console.WriteLine(sales[0]);
            
            //adding groups of info to aray
            int[] myScores = new int[5] { 100, 76, 88, 100, 90 };
            //this is the same
            string[] monthsOfYear = {"January", "Febuary", "March" };
            
            //using in a loop
            int[] array2 = new int[5];

            for(int count = 0; count < 5; count++)
            //for(int count = 0; array2.Lenght < 5; count++)
            {
                array2[count] = count;
            }
            
            //foreach loop
            foreach (int interVar in array2) ;
            {
                Console.WriteLine("This array value is {0}", interVar);

            }

            //multidimensional Arrays
            //picture it as a column of values (Spreadsheet style)
            //sales[0, 0] the first number is on the Y axis and the second number is on the x axis

            int[,] rents = { { 400, 450,510}
                             };


            

        }
    }
}
