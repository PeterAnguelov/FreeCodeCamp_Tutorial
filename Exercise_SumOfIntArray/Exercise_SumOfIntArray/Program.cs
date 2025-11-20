using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_SumOfIntArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] numbers = { 1, 2, 3, 4, 5, 6, 7, 8};
            bool result = SumOfNumbers(numbers, out int total);

            if (result)
            {
                Console.WriteLine($"The total is: {total}");
            }
            else
            {
                Console.WriteLine("Cannot add up an empty array!");
            }
        }

        static bool SumOfNumbers(int[] numbers, out int total)
        {
            total = 0;
            if (numbers.Length > 0)
            {
                
                foreach (int i in numbers)
                {
                    total += i;
                }
                return true;
            }
            
            return false;
        }
    }
}
