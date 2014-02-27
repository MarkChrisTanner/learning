using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feb11
{
    class Program
    {
        static void Main(string[] args)
        {

            //loops! no fruit
            //while
            //for
            //do

            /*         Int32 counter = 0, loopEnd;
                     string counterString;
                     Console.Write("Run loop how many times? ");
                     counterString = Console.ReadLine();
                     loopEnd = Convert.ToInt32(counterString);
                         while(counter < loopEnd)
     
             * {
                             counter++;
                             Console.WriteLine("This thing has run {0}", counter);


                         }
             * 
             
            string yourName = "";
            while (yourName != "Brian")
            {
                Console.Write("Type your name. ");
                yourName = Console.ReadLine();

            }
            

            int value;
            do
            {
                Console.WriteLine("what is the value? ");
                value = Convert.ToInt32(Console.ReadLine());
            } while (value != 0); //this set will run the do group first, then tests the condition and moves on if true, repeats if false.

             * */

            int value;

                for(value = 0;value < 10; ++value)
                {
                    Console.WriteLine("our value is {0}", value);
                }
        }
    }
}
