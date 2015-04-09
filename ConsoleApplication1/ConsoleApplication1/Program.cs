using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            //User inputs character to search for
            Console.WriteLine("Please enter a single character: ");
            string string1 = Console.ReadLine();
            //User types string to search
            Console.WriteLine("Please type a sentence: ");
            string string2 = Console.ReadLine();

            Console.WriteLine("The program will now count how many times your character exists uniquely in your sentence!");

            //Method Call
            SpecificLetterCounter(string1, string2);
            Console.ReadKey();
        }
        /// <summary>
        /// Creates a function that counts how many times a character exists in a particular string.
        /// </summary>
        /// <param name="letterToCount"></param>
        /// <param name="stringToSearch"></param>
        static void SpecificLetterCounter(string letterToCount, string stringToSearch)
        {
            //counts occurances of letter to count
            int counter = 0;

            //loop to iterate through stringToSearch
            for (int i = 0; i < stringToSearch.Length; i++)
            {
                if (stringToSearch[i].ToString() == letterToCount)
                {
                    counter++;
                }

            }
            //Output count of occurances to user
            Console.WriteLine("Your letter was counted {0} times!", counter);
        }
    }
}
