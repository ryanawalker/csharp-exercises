using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a radius: ");
            string input = Console.ReadLine();
            float radius;
            bool isNumber = float.TryParse(input, out radius);
            while (isNumber == false || radius < 0)
            {
                Console.Write("Enter a positive number for the radius: ");
                input = Console.ReadLine();
                isNumber = float.TryParse(input, out radius);
            }
            Console.WriteLine("The area of a circle with a radius of " + radius + " is: " + (radius * radius * 3.14));
            Console.ReadLine();
        }
    }
}
