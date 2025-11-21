using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchWindows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int age = 35;

            //if (age > 18)
            //{
            //    Console.WriteLine("18+");
            //}
            //else if (age > 30)
            //{
            //    Console.WriteLine("30+");
            //}

            string name = "Peter";
            int age;
            age = 23;

            if (age > 18)
            {
                Console.WriteLine("18+");
            }

            PrintDetails(name, age);

            string message = ReadFromConsole("Enter anything: ");
            Console.WriteLine(message);

        }

        static string ReadFromConsole(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        static void PrintDetails(string name, int age)
        {
            Console.WriteLine($"{name} - {age}");
        }
    }
}
