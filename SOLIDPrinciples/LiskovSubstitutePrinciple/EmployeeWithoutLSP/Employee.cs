
namespace SOLIDPrinciples.LiskovSubstitutePrinciple.EmployeeWithoutLSP
{
    class Employee
    {
        private readonly double Benefit;
        private double Salary;
        public string Name { get; private set; }
        public Employee(string name, double benefit, double salary)
        {
            Benefit = benefit;
            Salary = salary;
            Name = name;
        }

        public double GetSalary()
            => Salary;
        public double UpdateSalary(double increment)
            => Salary += increment;

        public double AddBenefitsInSalary()
            => Salary + Benefit;
    }
}
