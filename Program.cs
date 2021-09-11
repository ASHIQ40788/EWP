using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {

            EmployeeWageComputeArray empWageBuilder = new EmployeeWageComputeArray();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 20, 2, 10);
            empWageBuilder.computeEmpWage();
        }
    }
}
