using System;
using System.IO;

class WordCount
{
    public static void Main(String[] args)
    {
        // Check if there are no arguments
        if (args.Length == 0)
        {
            Console.WriteLine("You need to specify a text file as a command-line argument.");
            return;
        }

        // Check if file exists
        string filePath = args[0];
        if (!File.Exists(filePath))
        {
            Console.WriteLine("The file " + filePath + " does not exist.");
            return;
        }


        // Used to keep track of words that end with e and t
        int count = 0;

        // save text into fileContent
        string fileContent = File.ReadAllText(filePath);

        // Create an array containing chars to remove
        char[] charsToRemove = new char[] { ' ', '.', ',' };

        // Split the words based upon the charsToRemove, and remove empty results
        string[] words = fileContent.Split(charsToRemove, StringSplitOptions.RemoveEmptyEntries);

        // Loop over list
        foreach (string word in words)
        {
            // If the word ends with e or t, we increment
            if (word.ToLower().EndsWith("e") || word.ToLower().EndsWith("t"))
            {
                count++;
            }
        }

        // Print the file path and the count of words that end with e and t
        Console.WriteLine("The string from " + filePath + " contains " + count + " words that end with 'e' and 't'.");
    }
}