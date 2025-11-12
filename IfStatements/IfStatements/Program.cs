using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello my name is Aba!");

            /*Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            //Console.WriteLine(name);

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(age);

            //Console.Write("Your name is ");
            //Console.Write(name);
            //Console.Write(" and your age is ");
            //Console.Write(age);

            Console.WriteLine();
            Console.WriteLine($"Your name is {name} and your age is {age}");*/

            /*if (age < 0 || age > 150)
            {
                Console.WriteLine("Invalid age!");
            }
            else
            {
                if (age >= 18 && age <= 25)
                {
                    Console.WriteLine("You are between 18 and 25");
                }
                else if (age >= 26)
                {
                    Console.WriteLine("You are 26 or older");
                }
            }*/

            Console.Write("Enter the first number: ");
            int numberA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int numberB = Convert.ToInt32(Console.ReadLine());

            int answer = numberA * numberB;

            Console.Write($"Value of {numberA} x {numberB}: ");
            int actualAnswer = Convert.ToInt32(Console.ReadLine());

            if (answer == actualAnswer)
            {
                Console.WriteLine("Well done!");
            }
            else
            {
                Console.WriteLine("Wrong!");
            }

            Console.ReadLine();
        }
    }
}
