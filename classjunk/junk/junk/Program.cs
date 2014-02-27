// Program decides tuition based on several criteria:
// 1 - 12 credit hours @ $150 per credit hour
// 13 - 18 credit hours, flat fee $1900
// over 18 hours, $1900 plus $100 per credit hour over 18
// If year in school is 4, there is a 15% discount
using System;
class DebugFour3
{
    static void Main()
    {
        int credits, year;
        string inputString;
        double tuition;
        const int LOWCREDITS = 12;
        const int HIGHCREDITS = 18;
        const double HOURFEE = 15000;
        const double DISCOUNT = 0.15;
        const double FLAT = 1900.00;
        const double RATE = 100.00;
        const int SENIORYEAR = 4;
        Console.WriteLine("How many credits? ");
        inputString = Console.ReadLine();
        credits = Convert.ToInt32(inputString);
        Console.WriteLine("Year in school? ");
        inputString = Console.Readline();
        year = Convert.ToInt32(inputString);
        if (credits <= LOWCREDITS)
            tuition = HOURFEE * credits;
        else
            if (credits == HIGHCREDITS)
                tuition = FLAT;
            else
                tuition = FLAT + (credits - HIGHCREDITS) * RATE;
        if (year < SENIORYEAR)
            tuition = tuition - (tuition * DISCOUNT);
        Console.WriteLine("For year {0}, with {1} credits",
           year, credits);
        Console.WriteLine("Tuition is {0}", tuition.ToString("C"));
    }
}
