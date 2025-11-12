using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string speech = "He said \"something\"";
            string path = "C:\\Users\\CoffeeNCode\\Desktop\\C# Course\n";
            Console.WriteLine(path);
            Console.WriteLine(speech);

            path = @"C:\Users\CoffeeNCode\Desktop\C# Course\n";
            Console.WriteLine(path);

            string name = @"Hello 'some'";
            Console.WriteLine(name);

            Console.ReadLine();
        }
    }
}
