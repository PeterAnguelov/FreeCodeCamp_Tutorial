using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassToString
{
    class Person
    {
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

        public override string ToString()
        {
            return $"Name: {Name}\tAge: {Age}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Person)
            {
                Person person = obj as Person;
                return Name.Equals(person.Name) && Age == person.Age;
            }

            return false;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Peter", 24);
            Person test = new Person("Peter", 24);
            //Console.WriteLine(person.ReturnDetails());
            //Console.WriteLine(person.ToString());
            Console.WriteLine(person);

            if (person.Equals(test))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Not the Same");
            }

            int age = 23;
            Console.WriteLine(age);
        }
    }
}
