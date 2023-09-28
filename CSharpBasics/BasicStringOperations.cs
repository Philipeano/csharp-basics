using System;

namespace CSharpBasics
{
    internal class BasicStringOperations
    {
        // Accept 2 words, concatenate them, and display the result on the console.
        public void ConcatenateWords() 
        {
            // Prompt the user for the first word
            Console.WriteLine("Enter the first word...");
            string firstWord = Console.ReadLine();

            // Prompt the user for the second word
            Console.WriteLine("Enter the second word...");
            string secondWord = Console.ReadLine();

            // Concatenate both words
            string result = $"{firstWord} {secondWord}";

            // Display the output
            Console.WriteLine(result);
        }
    }
}
