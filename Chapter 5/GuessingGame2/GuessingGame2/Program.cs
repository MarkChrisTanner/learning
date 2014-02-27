using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ranNumber = new Random();
            int randomNumber;
            randomNumber = ranNumber.Next(1, 10);
            int troll;
            troll = ranNumber.Next(1, 10);
            int counter = 1;
        //    Console.WriteLine("The number is {0}", randomNumber);

            Console.WriteLine("This is a stupid little guessing game.");
            Console.WriteLine("And you seem to be foolish enough to play");
            Console.WriteLine("The computer thinks you should start with the number {0}", troll);
            Console.WriteLine("But the computer is a id10t.");
            Console.Write("Please tell me what you think the number is? ");
            int guess = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            while(!(guess == randomNumber))
                {
                if (guess > randomNumber)
                    {
                        Console.Clear();
                        Console.WriteLine("Your guess seems a little high.  Or a lot high.  Are you high?");
                        Console.WriteLine("Your last guess was {0}", guess);
                        Console.Write("Try again! ");
                        guess = Convert.ToInt32(Console.ReadLine());
                        counter = ++counter;
                    }
                if(guess < randomNumber)
                    {
                        Console.Clear();
                        Console.WriteLine("Your guess seems a little low. Did you think this was the Price Is Right?");
                        Console.WriteLine("Your last guess was {0}", guess);
                        Console.Write("Pleased if you would guess again. ");
                        guess = Convert.ToInt32(Console.ReadLine());
                        counter = ++counter;
                    }
            }
            Console.Clear();
            Console.WriteLine("After {0} tries you finally found the number {1} that you were looking for.", counter, randomNumber);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Fin");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
