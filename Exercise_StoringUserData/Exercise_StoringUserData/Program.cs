using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_StoringUserData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Name:");
            var name = Console.ReadLine();

            Console.Write("Enter Phone Number:");
            var phoneNumber = Console.ReadLine();

            Console.Write("Enter Age:");
            var age = Console.ReadLine();

            Console.WriteLine(name);
            Console.WriteLine(phoneNumber);
            Console.WriteLine(age);

            Console.ReadLine();
        }
    }
}
