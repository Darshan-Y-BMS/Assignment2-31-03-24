using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensAssignment2
{
    public class Developer : Employee
    {
        protected string ProgrammingLanguage;

        public Developer(string name, string employeeId, double salary, string ProgrammingLanguage):base(name,employeeId,salary)
        {
            base.Name = name;
            base.EmployeeId = employeeId;
            base.Salary = salary;
            this.ProgrammingLanguage = ProgrammingLanguage;
        }
        public void GetDetails()
        {
            Console.WriteLine($"Name                :{Name}");
            Console.WriteLine($"EmployeeId          :{EmployeeId}");
            Console.WriteLine($"Salary              :{Salary}");
            Console.WriteLine($"Programming Lang    :{ProgrammingLanguage}");

        }
        public void GetBonus()
        {
            this.Salary = Salary * (.25);

            Console.WriteLine($"Bonus               :{Salary}");
        }

    }

}
