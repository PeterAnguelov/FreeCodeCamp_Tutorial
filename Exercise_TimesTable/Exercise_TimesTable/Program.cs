using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_TimesTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool success = true;
            int num = 0;
            int times = 0;

            while (success)
            {
                Console.Write("Enter a number: ");
                string inputValue = Console.ReadLine();

                if (int.TryParse(inputValue, out num))
                {
                    success = false;
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine("Please enter a int value");
                }
            }

            success = true;

            while (success)
            {
                Console.Write("Enter a number: ");
                string inputValue = Console.ReadLine();

                if (int.TryParse(inputValue, out times))
                {
                    success = false;
                    Console.WriteLine(times);
                }
                else
                {
                    Console.WriteLine("Please enter a int value");
                }
            }

            Console.WriteLine("Times Table");
            for (int i = 1; i <= times; i++) 
            {
                int final = num * i;
                Console.WriteLine("{0} X {1} = {2}", num, i, final);
            }
        }
    }
}
