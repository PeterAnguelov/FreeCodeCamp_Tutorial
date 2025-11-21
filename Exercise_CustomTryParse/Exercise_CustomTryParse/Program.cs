using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_CustomTryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // FormatException
            // OverflowException
            /*bool loop = true;

            while (loop)
            {
                try
                {
                    Console.Write("Enter a number: ");
                    int num = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(num);
                    loop = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please only enter number");
                }
                catch (OverflowException) 
                {
                    Console.WriteLine("Please enter a number below 2 billion");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.ToString()}");
                }
            }
            Console.WriteLine("Good Bye");*/

            Console.Write("Enter a number: ");
            if (TryParse(Console.ReadLine(), out int result)) 
            {
                Console.WriteLine("Yay " + result);
            }
            else
            {
                Console.WriteLine("Oh no");
            }
            

        }

        static bool TryParse(string input, out int result)
        {
            result = -1;

            try
            {
                result = Convert.ToInt32(input);
                return true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please only enter number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please enter a number below 2 billion");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.ToString()}");
            }
            

            return false;
        }
    }
}
