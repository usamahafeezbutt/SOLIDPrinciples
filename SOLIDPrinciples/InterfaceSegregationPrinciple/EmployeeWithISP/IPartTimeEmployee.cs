
namespace SOLIDPrinciples.InterfaceSegregationPrinciple.EmployeeWithISP
{
    interface IPartTimeEmployee : IEmployee
    {
        public double RatePerHour { get; set; }
        public double WorkingHour { get; set; }
        double GetHoursWorked();
    }
}
