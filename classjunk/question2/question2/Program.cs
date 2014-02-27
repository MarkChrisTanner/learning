using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program named TipsList that accepts seven double values representing
tips earned by a waiter each day during the week. Display each of the values along
with a message that indicates how far it is from the average.
*/

namespace question2
{
    class Program
    {
        static void Main(string[] args)
        {
            enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
            string s = Enum.GetName(typeof(Days), 4);
            Console.WriteLine(s);

            Console.WriteLine("The values of the Days Enum are:");
            foreach (int i in Enum.GetValues(typeof(Days)))
                Console.WriteLine(i);

            Console.WriteLine("The names of the Days Enum are:");
            foreach (string str in Enum.GetNames(typeof(Days)))
                Console.WriteLine(str);
        }
    }
}
