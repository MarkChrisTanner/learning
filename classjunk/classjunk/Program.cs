using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classjunk
{
    class Program
    {
        static void Main(string[] args)
        {
            int joe = 200;
            Console.WriteLine(joe);
            string words = "varaibles are weird";
            Console.WriteLine(words);

            double money = 42.05;
            Console.Write("the thing costs to much. $");
            Console.WriteLine(money);

            string value = "I promis";

            Console.WriteLine("the thing costs {0}, really {1}, {0} ", money, value);



            double amount = 12.34205972;   
                string amountString;
                amountString = amount.ToString("F");
            Console.WriteLine(amountString);

            int state = 5;
            state = state + 2;
            state += 2;

                
        }
    }
}
