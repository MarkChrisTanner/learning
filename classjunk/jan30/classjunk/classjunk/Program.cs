using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classjunk
{
    class Program
    {
        enum DayOfWeek
        {
            SUNDAY, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY
        }

        static void Main(string[] args)
        {
            string ourstring = "He said \n \"wow\"";
            Console.WriteLine(ourstring);

            string name1 = "Amy";
            Console.WriteLine("string {0} is {1} characters long.",
                name1, name1.Length);

            Console.WriteLine((int)DayOfWeek.SUNDAY);
            string myNumber = Console.ReadLine();
           
            double myNumber2;
            myNumber2 = Convert.ToDouble(myNumber);
            Console.WriteLine(myNumber2);

           // Console.WriteLine("\a"); this line will make a beep.

        }
    }
}
