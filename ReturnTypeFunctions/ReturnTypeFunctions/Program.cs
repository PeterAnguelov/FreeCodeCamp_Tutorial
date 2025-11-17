using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnTypeFunctions
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            Console.Title = ReturnNameAgePair();
            PrintIntroduction();

            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = ReadNumberFromConsole();
            }

            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }

            int[] newNumbers = CreateRandomArray();

            foreach (var item in newNumbers)
            {
                Console.Write($"{item} ");
            }
        }

        static int[] CreateRandomArray()
        {
            int[] numbers = new int[3]
            {
                0, 1, 2
            };

            return numbers;
        }

        static int ReadNumberFromConsole()
        {
            Console.WriteLine("Enter a number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static string ReturnName()
        {
            return "Peter";
        }

        static int ReturnAge()
        {
            return 24;
        }

        static string ReturnNameAgePair()
        {
            return $"{ReturnName()} - {ReturnAge()}";
        }

        static void PrintIntroduction ()
        {
            Console.WriteLine($"Helo my name is {ReturnName()} and my age is {ReturnAge()}");
        }
    }
}
