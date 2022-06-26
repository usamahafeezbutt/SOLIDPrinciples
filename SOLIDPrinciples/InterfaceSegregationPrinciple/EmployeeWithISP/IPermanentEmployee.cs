
namespace SOLIDPrinciples.InterfaceSegregationPrinciple.EmployeeWithISP
{
    interface IPermanentEmployee : IEmployee
    {
        public double Benefit { get; set; }
        double AddBenefitsInSalary();
    }
}
