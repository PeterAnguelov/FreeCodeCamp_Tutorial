using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();
            CreateAndPrintArray();
        }

        static void CreateAndPrintArray()
        {
            int[] numbers = new int[3]
            {
                0, 1, 2
            };

            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }
        }

        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }
    }
}
