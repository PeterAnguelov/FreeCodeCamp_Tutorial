using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_AreaOfATriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = ReadInt("width");
            int height = ReadInt("height");

            Console.WriteLine($"Area of the triangle: {CalculateTriangle(width, height)}");
            
        }

        static int ReadInt(string message)
        {
            Console.Write($"Enter the {message} of the Triangle: ");
            return Convert.ToInt32(Console.ReadLine());
        }

            static double CalculateTriangle(int width, int height)
        {
            double result = (width * height) / 2;
            return result;
        }
    }
}
