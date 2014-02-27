using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
/* In the game Rock Paper Scissors, two players simultaneously choose one of
three options: rock, paper, or scissors. If both players choose the same option,
then the result is a tie. However, if they choose differently, the winner is
determined as follows */
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int x = r.Next(3);//Max range
            int y = r.Next(100);
            string computerPick = "no choice";
            string player = "no choice";
            
            if (y > 2)
            {
                if (x == 0)
                {
                    computerPick = "rock";
                }
                if (x == 1)
                {
                    computerPick = "paper";
                }
                if (x == 2)
                {
                    computerPick = "scissors";
                }

                Console.WriteLine("You dare to challenge the masterful champion of ROCK PAPER SCISSORS?");
                Console.WriteLine("The master accepts your challenge.");
                Console.WriteLine("1 shall be the rock, hard had unbreaking.");
                Console.WriteLine("2 shall be paper, that contains all knoledge.");
                Console.WriteLine("3 shall be scissors, that which devides all.");
                Console.Write("Enter your choice > ");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.Clear();


                if (input == 1)
                {
                    player = "rock";
                }
                if (input == 2)
                {
                    player = "paper";
                }
                if (input == 3)
                {
                    player = "scissors";
                }

                // Tie condition tester
                if (player == computerPick)
                {
                    Console.WriteLine("You have decided the same as the master. He is pleased by the fact that your two minds are as one.");
                }
                else
                {

                    //Victory decider section
                    if (player == "rock")
                    {
                        if (computerPick == "paper")
                        {
                            Console.WriteLine("The master has chosen PAPER, while the player shall suffer shame for decided to stand behind ROCK.");
                            Console.WriteLine("Master's Victory!");
                        }
                        if (computerPick == "scissors")
                        {
                            Console.WriteLine("The decicive choice of SCISSORS has failed the master against your ROCK.");
                            Console.WriteLine("Player's Victory.");
                        }
                    }
                    if (player == "paper")
                    {
                        if (computerPick == "scissors")
                        {
                            Console.WriteLine("The master has chosen {0} distroying the knoledge of your {1}.", computerPick, player);
                            Console.WriteLine("Master's Victory!");
                        }
                        if (computerPick == "rock")
                        {
                            Console.WriteLine("The master has chosen {0}, an unwise choice against {1}.", computerPick, player);
                            Console.WriteLine("Player's Victory.");
                        }
                    }
                    if (player == "scissors")
                    {
                        if (computerPick == "rock")
                        {
                            Console.WriteLine("The master has chosen {0}, a devistating blow against the players {1}.", computerPick, player);
                            Console.WriteLine("Master's Victory!");
                        }
                        if (computerPick == "paper")
                        {
                            Console.WriteLine("The master has chosen {0}, and failed to best the players {1}.", computerPick, player);
                            Console.WriteLine("Player's Victory.");
                        }
                    }

                }
            }
                else
                {
                    Console.WriteLine("The master names you a cheater and will not allow you to play.");
                }
        }
    }
}