using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_ArrayOfMultiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter a number to multple {num} with: ");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[length];

            for (int i = 0; i < length; i++)
            {
                numbers[i] = num * (i + 1);
            }

            foreach (int item in numbers)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
