using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProperties
{
    class Person
    {
        /*private string name;
        private int age;

        public string Name
        {
            get => name;
            set => name = !string.IsNullOrEmpty(value) ? value : "Invalid name";
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value >= 0 && value <= 150 ? value : -1;
            }
        }*/
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string ReturnDetails()
        {
            return $"Name: {Name}\nAge: {Age}";
        }

        /*public void SetName(string name)
        {
            this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name";
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetAge(int age)
        {
            this.age = age >= 0 && age <= 150 ? age : -1;
        }

        public int GetAge()
        {
            return this.age;
        }*/
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Peter", 24);

            Console.WriteLine(person.ReturnDetails());
            person.Name = "Harry";
            person.Age = 25;
            Console.WriteLine($"Your name is {person.Name} and your age is {person.Age}");
        }
    }
}
