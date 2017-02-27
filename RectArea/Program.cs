using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULATE AREA OF A RECTANGLE");
            Console.WriteLine("Length?");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Width?");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("The area of a rectangle with dimensions of " + length + " units by " + width + " units is " + (length * width) + " square units.");
            Console.ReadLine();
        }
    }
}
