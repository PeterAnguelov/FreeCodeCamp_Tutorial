using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool success = true;

            while (success)
            {
                Console.Write("How many times do you want to repeat it: ");
                string amount = Console.ReadLine();

                if (int.TryParse(amount, out int num))
                {
                    success = false;
                    FizzBuzz(num);
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }
            
            Console.ReadLine();
        }

        static void FizzBuzz (int num)
        {
            bool fizz = false;
            bool buzz = false;

            for (int i = 1; i <= num; i++)
            {
                fizz = i % 3 == 0;
                buzz = i % 5 == 0;

                if (fizz && buzz)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (buzz)
                {
                    Console.WriteLine("Buzz");
                }
                else if (fizz)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
