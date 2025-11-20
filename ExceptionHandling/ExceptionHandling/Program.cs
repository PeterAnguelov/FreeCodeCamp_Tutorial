using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // System.FormatException
            // System.OverflowException

            bool looping = true;
            while (looping) 
            {
                try
                {
                    Console.Write("Enter a number: ");
                    int num = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(num);
                    looping = false;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Please enter a number less than 2 billion");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please only enter numbers");
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong");
                }
            }
            
        }
    }
}
