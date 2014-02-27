using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll

/* ask for SSN, name, pay rate, hours workd.
 have a display of all information requested and gross pay, federal withholding a 15% or gross pay, 
 * state withholding @ 5% and net pay (gross - taxes.
 */
{
    class Program
    {
        static void Main(string[] args)
        {
            const double fedWithHoldRate = .15;
            const double stateWithHoldRate = .05;
            Console.Write("What is the employee's name? ");
            string employee = Console.ReadLine();
            Console.Write("What is the employee's Social Security number? ");
            string SSN = Console.ReadLine();
            Console.Write("What is the employee's pay rate? ");
            string rateString = Console.ReadLine();
            Console.Write("How many hours has the employee worked? ");
            string hoursString = Console.ReadLine();

            //this next section will run conversions.
            double payRate = Convert.ToDouble(rateString);
            double hours = Convert.ToDouble(hoursString);
            
            //this section will set and run multplication
            double gross = (hours * payRate);
            double fedWithHeld = (gross * fedWithHoldRate);
            double stateWithHeld = (gross * stateWithHoldRate);
            double net = (gross - (fedWithHeld + stateWithHeld));
            
            string grossDollar = gross.ToString("C");
            string fedDollar = fedWithHeld.ToString("C");
            string stateDollar = stateWithHeld.ToString("C");
            string netDollar = net.ToString("C");





            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(employee);
            Console.WriteLine(); 
            Console.WriteLine(SSN);
            Console.WriteLine(); 
            Console.WriteLine("Gross Pay is {0, 20}", grossDollar);
            Console.WriteLine();
            //Console.WriteLine("{0, 10}", grossDollar);
            Console.WriteLine("Federal Withholding is {0, 10}", fedDollar);
            Console.WriteLine();
            //Console.WriteLine("{0, 10}", fedDollar);
            Console.WriteLine("State Withholding is {0, 12}", stateDollar);
            Console.WriteLine(); 
            Console.WriteLine("---------------------------------");
            Console.WriteLine(); 
            Console.WriteLine("Net pay is {0, 22}", netDollar);
            Console.WriteLine();
        }
    }
}
