using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLengthCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string> {"12345", "1234", "56789", "434", "23245566", "lists", "chars", "five"};
            foreach (string item in myList)
            {
                if (item.Length == 5)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadLine();
        }
    }
}
