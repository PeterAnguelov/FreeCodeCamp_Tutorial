using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                1, 7, 0, 4, 7, 6, 5, 8, 9
            };

            string test = "";
            test.Replace(" ", "");

            Array.Sort(numbers);

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
