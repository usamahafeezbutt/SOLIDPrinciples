
namespace SOLIDPrinciples.LiskovSubstitutePrinciple.EmployeeWithLSP
{
    class ContractualEmployee : Employee
    {
        public int _years;
        public ContractualEmployee(string name, double salary, int years) : base(salary, name)
        {
            _years = years;
        }
        public int YearsInContract() => _years;

    }
}
