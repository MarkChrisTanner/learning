using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter
{
    class Program
    {
        static void Main(string[] args)
        {

            string tweet;
            int lenght;
            Console.Write("Please give me the tweet you want to send.  >");

            //tweet = "I am the very model"; used only for testing
            //lenght = 200; used only for testing

            tweet = Console.ReadLine();
            Console.WriteLine();

            lenght = tweet.Length;

            Console.WriteLine("Your tweet is {0} characters long.", lenght);


            if (lenght <= 140)
                {   Console.WriteLine("You can put that on twitter, but I'm not sure it's a good idea.");
                    Console.WriteLine("What would your mother say?");              
                }
            else
	            {
                    Int32 delete = (lenght - 140);
                    Console.WriteLine("The letters! They are to many!");
                    Console.WriteLine("You should delete {0} characters.", delete);
	            }


            Console.WriteLine();
            Console.WriteLine(tweet);
            Console.WriteLine();

        }
    }
}
