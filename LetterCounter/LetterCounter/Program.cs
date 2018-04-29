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

            Output(inputString, letterCount);

            // End 
            Console.ReadLine();
        }

        /// <summary>
        /// 콘솔 창에 글자 수 세기의 결과를 출력한다.
        /// </summary>
        /// <param name="letterCount"></param>
        private static void Output(string inputString, int letterCount)
        {
            if (letterCount > 0)
            {
                // Display inputString + " has " + letterCount + " characters."
                Console.WriteLine(inputString + " has " + letterCount + " characters.");
            }
            else
            {
                Console.WriteLine("Please write anything.");
            }
        }
    }
}
