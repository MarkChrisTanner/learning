using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*The Anderson, Bowman, and Claxton families are running their annual garage sale.

 * Write a console-based application named GarageSale that prompts the user for a
family initial (A, B, or C). Either uppercase or lowercase initials are valid. While the
user does not type Z, continue by prompting for the amount of a sale. Keep a
running total of the amount earned by each family. After the user types Z or z for
an initial, display each family’s total as well as a grand total made at the garage sale.
 */

namespace garagesale
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyA = 0.00;
            double moneyB = 0.00;
            double moneyC = 0.00;
            double grandTotal = 0.00;
            string input;
            double money;
            int transactions = 0;
            int test = 0;
            
                Console.Write("Enter A, B, or C to pick the family, Z will end the program ");
                input = Console.ReadLine();

                while (test == 0)
                {
                    switch (input)
                    {
                        case "A":
                            Console.Write("How much money was made in the sale? ");
                            money = Convert.ToDouble(Console.ReadLine());
                            moneyA = (moneyA + money);
                            transactions = ++transactions;
                            Console.Clear();
                            Console.WriteLine("The A family made ${0}", moneyA);
                            Console.Write("Enter A, B, or C to pick the family, Z will end the program ");
                            input = Console.ReadLine();
                            break;
                        case "a":
                            Console.Write("How much money was made in the sale? ");
                            money = Convert.ToDouble(Console.ReadLine());
                            moneyA = (moneyA + money);
                            transactions = ++transactions;
                            Console.Clear();
                            Console.WriteLine("The A family made ${0}", moneyA);
                            Console.Write("Enter A, B, or C to pick the family, Z will end the program ");
                            input = Console.ReadLine();
                            break;
                        case "B":
                            Console.Write("How much money was made in the sale? ");
                            money = Convert.ToDouble(Console.ReadLine());
                            moneyB = (moneyB + money);
                            transactions = ++transactions;
                            Console.Clear();
                            Console.WriteLine("The B family made ${0}", moneyB);
                            Console.Write("Enter A, B, or C to pick the family, Z will end the program ");
                            input = Console.ReadLine();
                            break;
                        case "b":
                            Console.Write("How much money was made in the sale? ");
                            money = Convert.ToDouble(Console.ReadLine());
                            moneyB = (moneyB + money);
                            transactions = ++transactions;
                            Console.Clear();
                            Console.WriteLine("The B family made ${0}", moneyB);
                            Console.Write("Enter A, B, or C to pick the family, Z will end the program ");
                            input = Console.ReadLine();
                            break;
                        case "C":
                            Console.Write("How much money was made in the sale? ");
                            money = Convert.ToDouble(Console.ReadLine());
                            moneyC = (moneyC + money);
                            transactions = ++transactions;
                            Console.Clear();
                            Console.WriteLine("The C family made ${0}", moneyC);
                            Console.Write("Enter A, B, or C to pick the family, Z will end the program ");
                            input = Console.ReadLine();
                            break;
                        case "c":
                            Console.Write("How much money was made in the sale? ");
                            money = Convert.ToDouble(Console.ReadLine());
                            moneyC = (moneyC + money);
                            transactions = ++transactions;
                            Console.Clear();
                            Console.WriteLine("The C family made ${0}", moneyC);
                            Console.Write("Enter A, B, or C to pick the family, Z will end the program ");
                            input = Console.ReadLine();
                            break;
                        case "Z":
                            test = 30;
                            break;
                        case "z":
                            test = 40;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Invalid choice, please try again");
                            Console.Write("Enter A, B, or C to pick the family, Z will end the program ");
                            input = Console.ReadLine();
                            break;
                    }
                }
                    Console.Clear();
                    Console.WriteLine("Family A made a total of ${0}", moneyA);
                    Console.WriteLine("Family B made a total of ${0}", moneyB);
                    Console.WriteLine("Family C made a total of ${0}", moneyC);
                    grandTotal = (moneyA + moneyB + moneyC);
                    Console.WriteLine("The sale made a total of ${0}", grandTotal);
                    Console.WriteLine("There were a total of {0} transactions", transactions);
            }
           }

        }