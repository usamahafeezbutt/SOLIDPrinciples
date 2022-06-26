
namespace SOLIDPrinciples.LiskovSubstitutePrinciple.EmployeeWithLSP
{
    class PermanantEmployee : Employee, IEmployeeBenefit
    {
        private double Salary;
        public string Name { get; private set; }
        public double Benefit { get; set; }

        public PermanantEmployee(string name, double benefit, double salary) : base(salary,name)
        {
            Benefit = benefit;
            Salary = salary;
            Name = name;
        }

        public double AddBenefitsInSalary()
            => Salary + Benefit;
    }
}
