
using System;

namespace SOLIDPrinciples.InterfaceSegregationPrinciple.EmployeeWithISP
{
    interface IEmployee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
        double CalculateSalary();
    }
}
