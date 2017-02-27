using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPGCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MILES PER GALLON CALCULATOR");
            Console.WriteLine("How far did you drive (in miles)?");
            double milesDriven = double.Parse(Console.ReadLine());
            Console.WriteLine("How many gallons of gas did you use?");
            double gasUsed = double.Parse(Console.ReadLine());
            Console.WriteLine("You averaged " + (milesDriven / gasUsed) + " miles-per-gallon.");
            Console.ReadLine();
        }
    }
}
