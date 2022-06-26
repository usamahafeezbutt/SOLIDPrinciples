

namespace SOLIDPrinciples.LiskovSubstitutePrinciple.EmployeeWithoutLSP
{
    class ContractualEmployee : Employee
    {
        public int _years;
        public ContractualEmployee(string name, double benefits, double salary, int years) : base(name, benefits, salary)
        {
            _years = years;
        }
        public int YearsInContract() => _years;
    }
}
