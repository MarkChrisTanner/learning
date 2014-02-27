using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hurricane
{
/*    The Saffir-Simpson Hurricane Scale classifies hurricanes into five categories
numbered 1 through 5. Write a console-based application named Hurricane
that outputs a hurricane’s category based on the user’s input of the wind
speed. Category 5 hurricanes have sustained winds of at least 157 miles per
hour. The minimum sustained wind speeds for categories 4 through 1 are 130,
111, 96, and 74 miles per hour, respectively. Any storm with winds of less than
74 miles per hour is not a hurricane. */

    /* cat 5 => 157
     * cat 4 >= 130
     * cat 3 >= 111
     * cat 2 >= 96
     * cat 1 >= 74
     * non huricane is < 74
     */
    
    class Program
    {
        static void Main(string[] args)
        {
            string speedString;
            int speed;
            
            Console.Write("How fast is the current wind speed in MPH of the storm? > ");
            speedString = Console.ReadLine();
            speed = Convert.ToInt32(speedString);

            Console.Clear();
            
            if (speed < 74)
            {
                Console.WriteLine("This Wind speed will not be classified as a Hurricane.");
            }
            else
                if(speed < 96)
            {
                Console.WriteLine("This Wind speed would be classified as a Category 1 Hurricane.");
            }   else
                    if(speed < 111)
                    { Console.WriteLine("This Wind speed would be classified as a Category 2 Hurricane."); 
                    }
                    else
                    {
                        if(speed < 130)
                            Console.WriteLine("This Wind speed would be classified as a Category 3 Hurricane.");
                        else
                            if(speed < 157)
                                Console.WriteLine("This Wind speed would be classified as a Category 4 Hurricane.");
                            else
                            {
                                if(speed >= 157)
                                    Console.WriteLine("This Wind speed would be classified as a Category 5 Hurricane.");
                            }
                    }

        }
    }
}
