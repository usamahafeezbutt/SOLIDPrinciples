
namespace SOLIDPrinciples.InterfaceSegregationPrinciple.EmployeeWithISP
{
    interface IContractualEmployee : IEmployee
    {
        public double Year { get; set; }
        double YearsInContract();
    }
}
