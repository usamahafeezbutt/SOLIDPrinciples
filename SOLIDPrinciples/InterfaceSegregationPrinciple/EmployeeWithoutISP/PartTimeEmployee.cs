using SOLIDPrinciples.InterfaceSegregationPrinciple.OrderWithoutISP;
using System;

namespace SOLIDPrinciples.InterfaceSegregationPrinciple.EmployeeWithoutISP
{
    class PartTimeEmployee : IEmployee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }
        public double Benefit { get; set; }
        public double Salary { get; set; }
        public double RatePerHour { get; set; }
        public double Year { get; set; }
        public double WorkedHour { get; set; }
        public double WorkingHour { get; set; }

        public double AddBenefitsInSalary()
        {
            throw new NotImplementedException();
        }

        public double CalculateSalary() => WorkedHour * RatePerHour;

        public double GetHoursWorked() => WorkedHour;

        public double YearsInContract()
        {
            throw new NotImplementedException();
        }
    }
}
