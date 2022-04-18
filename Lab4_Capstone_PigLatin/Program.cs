using System;
using System.Collections.Generic;

namespace Lab4_Capstone_PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = new char[] {'a', 'e', 'i', 'o', 'u', 'y'};
            bool doingLab4 = true;
            while(doingLab4)
            {
                Console.WriteLine("Enter a word and I will translate it into Pig Latin for you!");
                Console.Write("Your Word: ");
                string userWordString = Console.ReadLine().ToLower();
                Console.WriteLine("");

                if(userWordString.IndexOfAny(vowels) == 0)
                {
                    Console.WriteLine($"Pig Latin: {userWordString}way");
                    Console.WriteLine("");
                }
                else
                {
                    // this is not right and I need to figure out how to split the words starting at the first vowel
                    Console.WriteLine("");
                    Console.WriteLine($"Pig Latin: {userWordString}ay");
                    Console.WriteLine("");
                }
                doingLab4 = RunProgramAgainPrompt();
            }
            Console.WriteLine("Thanks for using the Pig Latin program!");
            Console.WriteLine("Goodbye...");
        }
        static bool RunProgramAgainPrompt()
        {
            bool promptingUser = true;
            while (promptingUser)
            {
                Console.WriteLine("Would you like to translate the pig latin for another word?");
                Console.WriteLine("Enter 'y' or 'yes' to do another exercise, or enter 'n' or 'no' to exit the program.");
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "y" || userInput == "yes")
                {
                    Console.Clear();
                    promptingUser = false;
                    return true;
                }
                else if (userInput == "n" || userInput == "no")
                {
                    Console.Clear();
                    promptingUser = false;
                    return false;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Sorry, I didn't understand that response. Please try again.");
                    Console.WriteLine("");
                    promptingUser = true;
                }
            }
            return false;
        }
    }
}
