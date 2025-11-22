using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVariables
{
    class Person
    {
        private string name;
        private int age;
        private string test = "hello";
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            string test = "hi";
            Console.WriteLine(test);
        }

        public string ReturnDetails()
        {
            return $"Name: {name}\nAge: {age}";
        }

        public void SetName(string name)
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
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Peter", 24);

            Console.WriteLine(person.ReturnDetails());
        }

        static void something(Person person)
        {
            Console.WriteLine(person.GetName());
        }
    }
}
