using System;

namespace SOLIDPrinciples.InterfaceSegregationPrinciple.OrderWithoutISP
{
    interface IEmployee
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
        double CalculateSalary();
        double AddBenefitsInSalary();
        double YearsInContract();
        double GetHoursWorked();
    }
}
