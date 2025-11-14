using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Exercise_PasswordChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();
            Console.Write("Enter another password: ");
            string anotherPassword = Console.ReadLine();

            if (!string.IsNullOrEmpty(password))
            {
                if(!string.IsNullOrEmpty(anotherPassword))
                {
                    if (password.Length >= 6 && anotherPassword.Length >= 6)
                    {
                        if (password.Equals(anotherPassword))
                        {
                            Console.WriteLine("Passwords match");
                        }
                        else
                        {
                            Console.WriteLine("Passwords do not match");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter 6 or more characters");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Please enter a password confirmation");
                }
            } 
            else
            {
                Console.WriteLine("Please enter a password");
            }
        }
    }
}
