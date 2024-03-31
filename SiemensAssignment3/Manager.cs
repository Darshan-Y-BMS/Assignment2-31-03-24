using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SiemensAssignment2
{
    public class Manager : Employee
    {
        protected string Department;

        public Manager(string name, string employeeId, double salary, string department):base(name,employeeId,salary)
        {
            base.Name = name;
            base.EmployeeId = employeeId;
            base.Salary = salary;
            this.Department = department;
        }

        public void GetDetails()
        {
            Console.WriteLine($"Name                :{Name}");
            Console.WriteLine($"EmployeeId          :{EmployeeId}");
            Console.WriteLine($"Salary              :{Salary}");
            Console.WriteLine($"Department          :{Department}");

        }
        public void GetBonus()
        {
            this.Salary = Salary * (.50);

            Console.WriteLine($"Bonus               :{Salary}");
        }
    }

}
