using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Add(5);
            Console.WriteLine(result);

            PrintName("Joe");
        }

        static void PrintName(string name = "Peter")
        {
            Console.WriteLine($"My name is {name}");
        }

        static int Add(int x, [Optional]int y)
        {
            return x + y;
        }
    }
}
