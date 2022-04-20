using System;
using System.Collections.Generic;

namespace Lab4_Capstone_PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = new char[] {'a', 'e', 'i', 'o', 'u', 'y'};
            char[] alphabetLetters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] separators = new char[] { ' ', '.' };
            bool doingLab4 = true;

            Console.WriteLine("Welcome to the Pig Latin phrase generator!");
            Console.WriteLine("");
            while(doingLab4)
            {
                Console.WriteLine("Enter a word and I will translate it into Pig Latin for you!");
                Console.WriteLine("");
                Console.Write("Your phrase: ");
                string userWordString = Console.ReadLine().ToLower();
                string[] subs = userWordString.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                Console.Write("Pig Latin phrase: ");

                foreach (var sub in subs)
                {
                    if (sub.StartsWith('a') || sub.StartsWith('e') || sub.StartsWith('i') || sub.StartsWith('o') || sub.StartsWith('u') || sub.StartsWith('y'))
                    {
                        string splitFrontOfWord = sub.Substring(0, sub.IndexOfAny(vowels));
                        string newShortString = sub.Remove(0, sub.IndexOfAny(vowels));
                        Console.Write($"{newShortString}{splitFrontOfWord}way ");
                    }
                    else
                    {
                        string splitFrontOfWord = sub.Substring(0, sub.IndexOfAny(vowels));
                        string newShortString = sub.Remove(0, sub.IndexOfAny(vowels));
                        Console.Write($"{newShortString}{splitFrontOfWord}ay ");
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("");
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
                Console.WriteLine("Would you like to translate the pig latin for another phrase?");
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
