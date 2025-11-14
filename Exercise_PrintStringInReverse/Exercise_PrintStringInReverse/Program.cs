using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Exercise_PrintStringInReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter in a message: ");
            string message = Console.ReadLine();

            if (!string.IsNullOrEmpty(message))
            {
                for (int i = 0; i < message.Length; i++)
                {
                    Console.Write(message[i]);
                }

                Console.WriteLine();

                for (int i = message.Length - 1; i >= 0; i--)
                {
                    Console.Write(message[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
