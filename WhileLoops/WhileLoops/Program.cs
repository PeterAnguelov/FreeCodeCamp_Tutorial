using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;

            //while (i < 10)
            //{
            //    i++;
            //    Console.WriteLine(i);
            //}

            Console.Write("Enter the first number: ");
            int numberA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int numberB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int answer = numberA * numberB;
            int actualAnswer = 0;

            Console.Write($"Whats the value of {numberA} x {numberB}?");
            Console.WriteLine();

            /*while (answer != actualAnswer)
            {
                Console.Write("Enter your answer: ");
                actualAnswer = Convert.ToInt32(Console.ReadLine());

                if (answer != actualAnswer)
                {
                    Console.WriteLine("Wrong!");
                    Console.WriteLine();
                }
            }*/

            do
            {
                Console.Write("Enter your answer: ");
                actualAnswer = Convert.ToInt32(Console.ReadLine());

                if (answer != actualAnswer)
                {
                    Console.WriteLine("Wrong!");
                    Console.WriteLine();
                }
            } while (answer != actualAnswer);

            Console.WriteLine("Well done!");

            Console.ReadLine();
        }
    }
}
