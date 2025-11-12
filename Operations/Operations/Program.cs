using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 23;

            age++;
            age += 10;
            Console.WriteLine(age);
            age--;
            Console.WriteLine(age);

            double doubleAge = 23;
            doubleAge /= 10;
            Console.WriteLine(doubleAge);

            string name = "Aba";
            name += " is programming";
            Console.WriteLine(name);

            char ch = 'a';
            ch += 'b';
            Console.WriteLine(ch);

            int i = 0;
            Console.WriteLine(++i);

            Console.ReadLine();
        }
    }
}
