using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                0, 1, 2, 3, 4, 5
            };

            int[] sortedNumbers = new int[numbers.Length];

            int x = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                sortedNumbers[x] = numbers[i];
                x++;
            }

            //Array.Reverse(numbers);

            foreach (var num in sortedNumbers)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
