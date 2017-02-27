using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlice
{
    class Program
    {
        static void Main(string[] args)
        {
            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine("SEARCH THE FIRST SENTENCE OF ALICE'S ADVENTURES IN WONDERLAND");
            Console.WriteLine("What string would you like to search for?");
            string substring = Console.ReadLine();
            if (alice.ToLower().IndexOf(substring.ToLower()) < 0)
            {
                Console.WriteLine("false");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("true");
                Console.ReadLine();
            }
        }
    }
}
