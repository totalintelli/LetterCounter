using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Letter Counter

            // Initialize inputString to ""
            string inputString = "";
            // Initialize letterCount to 0
            int letterCount = 0;

            // Prompt for letter with "What is the input string?"
            Console.Write("What is the input string?");
            inputString = Console.ReadLine();

            // Get letterCount from inputString
            letterCount = inputString.Length;

            if (letterCount > 0)
            {
                // Display inputString + " has " + letterCount + " characters."
                Console.WriteLine(inputString + " has " + letterCount + " characters.");
            }
            else
            {
                Console.WriteLine("Please write anything.");
            }

            // End 
            Console.ReadLine();
        }
    }
}
