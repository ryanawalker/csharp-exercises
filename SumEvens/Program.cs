using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumEvens
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            List<int> nums = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            foreach (int num in nums)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            Console.WriteLine("The sum of even numbers in the list is " + sum +".");
            Console.ReadLine();
        }
    }
}
