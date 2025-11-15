using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int angleCount = 3;
            int[] angles = new int[angleCount];

            for (int i = 0; i < angles.Length; i++)
            {
                Console.Write($"Enter angle {i + 1}: ");
                angles[i] = Convert.ToInt32(Console.ReadLine());
            }

            int anglesum = 0;

            foreach (var angle in angles)
            {
                anglesum += angle;
            }

            Console.WriteLine(anglesum == 180 ? "Valid" : "Invalid");

            //int anglesum = angle1 + angle2 + angle3;

            //Console.WriteLine(anglesum == 180 ? "Valid" : "Invalid");
        }
    }
}
