using SOLIDPrinciples.InterfaceSegregationPrinciple.OrderWithoutISP;
using System;

namespace SOLIDPrinciples.InterfaceSegregationPrinciple.EmployeeWithoutISP
{
    class ContractualEmployee : IEmployee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }
        public double Benefit { get; set; }
        public double Salary { get; set; }
        public double RatePerHour { get; set; }
        public double Year { get; set; }
        public double WorkingHour { get; set; }

        public double AddBenefitsInSalary()
        {
            throw new NotImplementedException();
        }

        public double CalculateSalary() => Salary;

        public double GetHoursWorked()
        {
            throw new NotImplementedException();
        }

        public double YearsInContract() => Year;
    }
}
