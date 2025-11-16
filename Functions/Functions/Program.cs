using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Test
    {
        public void something()
        {
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main()
        {
            Test test = new Test();
            test.something();
            WelcomeMessage();
        }

        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome Aba");
        }
    }
}
