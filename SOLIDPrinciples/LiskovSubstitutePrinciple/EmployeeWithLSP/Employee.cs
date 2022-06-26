using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.LiskovSubstitutePrinciple.EmployeeWithLSP
{
    class Employee
    {
        private double Salary;
        public string Name { get; private set; }
        public Employee(double salary, string name)
        {
            Salary = salary;
            Name = name;
        }
        public double GetSalary()
            => Salary;
        public double UpdateSalary(double newSalary)
            => Salary = newSalary;
    }
}
