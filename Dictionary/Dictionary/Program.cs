using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dictionary<int, string> names = new Dictionary<int, string>()
            {
                //KeyValuePair
                {1, "Peter" },
                {2, "Test" },
                {3, "Test" }
            };

            for (int i = 0; i < names.Count; i++)
            {
                KeyValuePair<int, string> pair = names.ElementAt(i);
                
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }

            foreach (KeyValuePair<int, string> item in names)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }*/

            Dictionary<string, string> teachers = new Dictionary<string, string>
            {
                {"Math", "Peter" },
                {"Science", "Test" }
            };

            //Console.WriteLine(teachers["Math"]);

            if (teachers.TryGetValue("Math", out string teacher))
            {
                Console.WriteLine(teacher);

                teachers["Math"] = "Joe";
            }
            else
            {
                Console.WriteLine("Math Teacher not found");
            }

            if (teachers.ContainsKey("Math"))
            {
                teachers.Remove("Math");
            }
            else
            {
                Console.WriteLine("Math not found");
            }

            foreach (var item in teachers)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
