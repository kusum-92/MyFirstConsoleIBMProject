using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIBMProject
{
    internal class Person
    {
        //public data members of Person class
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Age { get; set; }

        public Person() { }
        public Person(int id, string name, string city, int age)
        {
            Id = id;
            Name = name;
            City = city;
            Age = age;
        }

        public void DisplayPersonDetails()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"City: {City}");
            Console.WriteLine($"Age: {Age}");
        }

        public string GetPersonInfo()
        {
            return $"Id: {Id}, Name: {Name}, City: {City}, Age: {Age}";
        }
        public void UpdatePersonDetails(string name, string city, int age)
        {
            Name = name;
            City = city;
            Age = age;
        }
        public string getPersonDetails()
        {
            return $"Id: {Id}, Name: {Name}, City: {City}, Age: {Age}";
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, City: {City}, Age: {Age}";
        }

    }
}
