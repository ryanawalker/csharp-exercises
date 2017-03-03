using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CountCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            if (testString == "")
            {
                Console.WriteLine("No string entered, using default test string:");
                Console.WriteLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.");
                testString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            }
            */

            // Initialize variables.
            string menuChoice = "";
            string testString = "";

            // Draw main menu.
            do
            {
                Console.WriteLine("Choose:");
                Console.WriteLine("prompt - Read From Prompt");
                Console.WriteLine("file - Read From File");
                menuChoice = Console.ReadLine();
            } while (menuChoice != "prompt" && menuChoice != "file");

            // Handle prompt entry.
            if (menuChoice == "prompt")
            {
                Console.Write("Enter a string to be CharCounted: ");
                testString = Console.ReadLine();
            }
            // Handle file entry.
            else
            {
                Console.Write("Enter the location of .txt file to be CharCounted (ex: C:\\file.txt): ");
                string fileLocation = Console.ReadLine();
                testString = File.ReadAllText(@fileLocation, Encoding.UTF8);
            }

            
            // Iterate through string, create dictionary, increment if char exists in dictionary, initialize if not.
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (char letter in testString.ToLower())
            {
                if (Char.IsLetter(letter) || Char.IsNumber(letter))
                {
                    if (charCount.ContainsKey(letter))
                    {
                        charCount[letter] += 1;
                    }
                    else
                    {
                        charCount[letter] = 1;
                    }
                }
            }

            // Print result parings.
            foreach (KeyValuePair<char, int> letter in charCount)
            {
                Console.WriteLine(letter.Key + ": " + letter.Value);
            }
            Console.ReadLine();
        }
    }
}