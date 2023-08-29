/// Week No. 2 Homework Part No. 1
/// File Name: PigLatinTranslator.cs
/// @author: Jason Hamrick
/// Date: August 28, 2023
///
/// Problem Statement:
/// Translate a name to pig Latin using only the rule
/// of moving the first letter to the end of the word and adding “ay”.
/// Output the result to the screen.
///
/// Overall Plan:
/// 1) Store the first and last names as strings in two variables.
/// 2) For each string, move the first letter to the end.
/// 3) Concatenate "ay" to the end.
/// 4) Capitolize the new first letter.
/// 5) Concatenate the strings together and store in a new variable.
/// 6) Print the result to the console.
///

namespace Homework2_Part1
{
    class PigLatinTranslator
    {
        static void Main(string[] args)
        {
            // Store the first and last names as strings in two variables.
            string firstName = "jason";
            string lastName = "hamrick";

            // Moves the first letter of a string to the end.
            static string moveFirstLetter(string input)
            {
                string firstLetter = input.Substring(0, 1);
                return input.Substring(1) + firstLetter;
            }

            // Adds "ay" to the end of a string.
            static string addAy(string input)
            {
                return input + "ay";
            }

            // Capitalizes the first letter of a string.
            static string capitalize(string input)
            {
                string firstLetter = input.Substring(0, 1);
                return firstLetter.ToUpper() + input.Substring(1);
            }

            // Calls and passes a string into the moveFirstLetter(), addAy(), and capitalize() methods.
            static string pigLatinify(string input)
            {
                string stepOne = moveFirstLetter(input);
                string stepTwo = addAy(stepOne);
                return capitalize(stepTwo);
            }

            // Calls pigLatinify() on two strings and concatenates them together with a space.
            static string translateFullName(string firstName, string lastName)
            {
                return pigLatinify(firstName) + " " + pigLatinify(lastName);
            }

            Console.WriteLine(translateFullName(firstName, lastName));

        }
    }
}