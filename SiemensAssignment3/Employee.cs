using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensAssignment2
{
    public class Employee
    {
        protected string Name;
        protected string EmployeeId;
        protected double Salary;

        public Employee(string name, string employeeid, double salary)
        {
            this.Name = name;
            this.EmployeeId = employeeid;
            this.Salary = salary;
        }
       
    }

}
