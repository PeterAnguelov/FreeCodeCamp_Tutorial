using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFields
{
    internal class Program
    {
        class Person
        {
            private string name;
            private int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public string ReturnDetails()
            {
                return $"Name: {name}\nAge: {age}";
            }

            public void SetName(string name)
            {
                /*if (!string.IsNullOrEmpty(name))
                {
                    this.name = name;
                }
                else
                {
                    this.name = "Invalid name";
                }*/

                this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name";
            }

            public string GetName()
            {
                return this.name;
            }

            public void SetAge(int age)
            {
                /*if (age >= 0 && age <= 150)
                {
                    this.age = age;
                }
                else
                {
                    this.age = -1;
                }*/

                this.age = age >= 0 && age <= 150 ? age : -1;
            }

            /*public int GetAge()
            {
                return this.age;
            }*/

            public int GetAge() => this.age;
        }

        static void Main(string[] args)
        {
            Person person = new Person("Peter", 24);

            Console.WriteLine(person.ReturnDetails());

            //person.name = "Harry";
            //person.age = 25;
            person.SetName("Harry");
            person.SetAge(25);
            Console.WriteLine(person.ReturnDetails());

            Console.WriteLine($"Your name is: {person.GetName()} and you age is: {person.GetAge()}");
        }
    }
}
