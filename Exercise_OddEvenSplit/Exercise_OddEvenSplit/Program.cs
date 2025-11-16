using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_OddEvenSplit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> odd = new List<int>();
            List<int> even = new List<int>();

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(i);
                } else
                {
                    odd.Add(i);
                }
            }

            Console.WriteLine("Printing Odd Numbers");
            printList(odd);

            Console.WriteLine(Environment.NewLine + "Printing Even Numbers");
            printList(even);
        }

        static void printList(List<int> list)
        {
            foreach (int i in list)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
