using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.LiskovSubstitutePrinciple.EmployeeWithLSP
{
    interface IEmployeeBenefit
    {
        double Benefit { get; set; }
        public double AddBenefitsInSalary();
    }
}
