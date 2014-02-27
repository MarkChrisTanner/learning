using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pigLatin
{
    /*Pig Latin is a nonsense language. To create a word in pig Latin, you remove the first
letter and then add the first letter and“ay”at the end of the word. For example,
“dog”becomes“ogday”and“cat”becomes“atcay”. Write a program named
PigLatin that allows the user to enter a word. Output the pig Latin version. */


    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("What word would you like translated into pig Latin? ");
            String word = Console.ReadLine();
            /*Console.WriteLine(word.Substring(0, word.Length));
            Console.WriteLine(word.Substring(2, 2));
            Console.WriteLine(word.Substring(1, 2));
            Console.WriteLine(word.Length);
            int letters = (word.Length - 1);
            Console.WriteLine(letters);
            Console.Write(word.Substring(1, letters));
             This was the first attempt. I went to "http://www.dreamincode.net/forums/topic/178601-english-to-pig-latin-translator/" 
             * to study a program that worked and Later noticed the word.Lenth value was what was causing me the problem, one that this 
             * programer solved by "word.lengh - 1"  I used two lines with some modifications, but the 
             * rest of the program is from scratch. I even hit upon the solution in the line where i set the
             * int for letters.
             */
            string firstLetter = word.Substring(0, 1);
            string restOfWord = word.Substring(1, word.Length - 1); 
            Console.WriteLine("{0} in pig latin would be ", word);
            Console.Write(restOfWord);
            Console.Write(firstLetter);
            Console.WriteLine("ay");
        }
    }
}
