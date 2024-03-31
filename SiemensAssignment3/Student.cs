using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensAssignment2
{
    public class Student : Person
    {
        public char grade;

        public Student(string name, int age, char grade) : base(name, age)
        {
            this.grade = grade;
        }
        public void getDetails()
        {
            base.getDetails();
            Console.WriteLine("Grade                      : " + grade);
        }

    }

}
