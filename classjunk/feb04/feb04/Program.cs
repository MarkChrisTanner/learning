using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feb04
{
    class Program
    {
        static void Main(string[] args)
        {

       //     if(//coneition to test)
       //     { // code to execute};
            // the if() statement must not have a ; or it will be a complete block that will only test the condition.)
            /* if(condition)
             *  {will execute all code in 
             *  curley braces}
             */
            if (1 == 1)
                Console.WriteLine("true story");

            //nesting if statement
               /* if()
                {
                    if()}

                    const  int HIGH = 10;
                    string numberString;
                    int number;
                    Console.Write("Enter an integer.");
                    numberString = = Console.ReadLine();
                    number - Convert.ToInt32 numberString;
                    if (number > HIGH)
                    {}
                    // the use of AND and OR \operators allow for more conditions in the if() statement.
                    //AND operators are written as &&
                    //OR operators are two || (pipe symboles)

                    //switch structure will test a single variable against a series of exact matches
                 */   // switch must terminate with the work break
                    
                    int year = 3;
                    switch(year)
                    {
                        case 1:
                        Console.WriteLine("freshman");
                            break;

                        case 2:
                        Console.WriteLine("sophmore");
                            break;

                        case 3:
                            Console.WriteLine("you are fired.");
                            break;

                        default:  
                            Console.WriteLine("you are fail");
                            break;
                        
                    }

                    if (year == 1)
                        Console.WriteLine("fart");
                    else if (year == 2)
                        Console.WriteLine("fart");
                    else
                        if (year == 3)
                        //do something
            //conditional operator
                        // used as an abbreviated version of the if-else statement

                        // console.writeline((testScore >= 60) ? "Pass": "Fail";

            // NOT operator written as an exclamation point (!)
                        //the ! operator has a higher precedence then && and ||

        }
           
    }
}
