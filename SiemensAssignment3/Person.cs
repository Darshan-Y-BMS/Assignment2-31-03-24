using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensAssignment2
{
    public class Person
    {
        protected string Name;
        protected int Age;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void getDetails()
        {
            Console.WriteLine("Name                       : " + Name);
            Console.WriteLine("Age                        : " + Age);
        }
    }

}
