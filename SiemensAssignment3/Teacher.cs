using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensAssignment2
{
    public class Teacher : Person
    {
        public string[] SubjectList;

        public Teacher(string name, int age, string[] subjectList) : base(name, age)
        {
            this.SubjectList = subjectList;
        }
        public void getDetails()
        {
            base.getDetails();
            Console.Write("List of subjects           : ");
            for (int i = 0; i < SubjectList.Length; i++)
            {
                Console.Write(SubjectList[i] + ", ");
            }
            Console.WriteLine();
        }
    }

}
