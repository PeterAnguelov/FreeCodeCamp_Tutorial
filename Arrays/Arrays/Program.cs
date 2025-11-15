using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            //Console.Write("Enter a number: ");
            //numbers[0] = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter a number: ");
            //numbers[1] = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter a number: ");
            //numbers[2] = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter a number: ");
            //numbers[3] = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]} {numbers[3]}");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter a number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

            foreach (var num in numbers)
            {
                Console.Write($"{num} ");
            }

            Console.ReadLine();
        }
    }
}
