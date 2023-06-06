using Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
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

        public void InfoPerson()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }

    class Karyawan : Person
    {
        public string JobTitle { get; set; }
        public Karyawan(string name, int age, string jobTitle) : base(name, age)
        {
            JobTitle = jobTitle;
        }

        public void InfoPerson()
        {
            base.InfoPerson();
            Console.WriteLine("Job Title: " + JobTitle);
        }
    }
}
