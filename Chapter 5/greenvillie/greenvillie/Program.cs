using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenvilleRevenue
{
    class Program
    {

        /*        write
        a program named GreenvilleRevenue that prompts a user for the number of
        contestants entered in last year’s competition and in this year’s competition. Display
        all the input data. Compute and display the revenue expected for this year’s
        competition if each contestant pays a $25 entrance fee. Also display a statement that
        indicates whether this year’s competition has more contestants than last year’s.
                */

        static void Main(string[] args)
        {

            const int fee = 25;
            int contestantsLastYear;
            int contestantsThisYear;
            int revenueLast;
            int revenueCurrent;

            Console.Write("How many contestants entered last years competition?  ");
            string input = Console.ReadLine();
            contestantsLastYear = Convert.ToInt32(input);
            //Console.WriteLine(contestantsLastYear);

            Console.Write("How many contestans are expected to enter this year?  ");
            input = Console.ReadLine();
            contestantsThisYear = Convert.ToInt32(input);
            //Console.WriteLine(contestantsThisYear);
            while(!(contestantsLastYear >= 0 && contestantsLastYear <= 30))
                {
                    Console.Clear();
                    Console.WriteLine("The number entered for last years contestants seems not to be valid.");
                    Console.WriteLine("Please enter a number between 0 and 30");
                    contestantsLastYear = Convert.ToInt32(Console.ReadLine());
                }
            while (!(contestantsThisYear >= 0 && contestantsThisYear <= 30))
            {
                Console.Clear();
                Console.WriteLine("The number entered for this years contestants seems not to be valid.");
                Console.WriteLine("Please enter a number between 0 and 30");
                contestantsThisYear = Convert.ToInt32(Console.ReadLine());
            }

            revenueCurrent = (fee * contestantsThisYear);
            revenueLast = (fee * contestantsLastYear);
            bool attendance = (contestantsThisYear > contestantsLastYear);

            Console.Clear();
            Console.WriteLine("Last year there were {0} number of contestants.", contestantsLastYear);
            Console.WriteLine("This year there are {0} contestants registered", contestantsThisYear);
            Console.WriteLine("The revenue from last year was ${0}", revenueLast);
            Console.WriteLine("The projected revenue this year is ${0}", revenueCurrent);
            //Console.WriteLine("it is {0} that their are more people attending this year then last.", attendance);

            if (contestantsThisYear < contestantsLastYear)
            {
                Console.WriteLine("A tighter race this year! Come out and cast your vote!");
            }

            if ((contestantsThisYear > contestantsLastYear) && (contestantsThisYear < (contestantsLastYear * 2)))
                Console.WriteLine("The competition is bigger than ever!");

            if (contestantsThisYear >= contestantsLastYear)
                Console.WriteLine("The competition is more than twice as big this year!");



            /*            If the competition has more than twice as many contestants as last year, display
            “The competition is more than twice as big this year!”
            l If the competition is bigger than last year’s but not more than twice as big,
            display“The competition is bigger than ever!”
            l If the competition is smaller than last year’s, display,“A tighter race this year!
            Come out and cast your vote!”
            */



        }
    }
}
