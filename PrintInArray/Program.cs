using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 1, 2, 3, 5, 8 };
            foreach (int num in myArray)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
