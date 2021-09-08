using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class EmployeeWageCompute
    {
        //constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        public static int computeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            //local Variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            
            //Computation
           while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                //Predefined Random class for generating random values
                Random random = new Random();

                //Computation
                //Next method() 0-initial value,2-number of elemnets from 0
                int empCheck = random.Next(0, 3);
                //switch selection statement-execution steps are less
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs : " + empHrs);
                //Console.WriteLine($"Day {day} EmployeeWage is = {empWage}");
                //totalEmpWage += empWage;
            }

            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("total emp Wage for company:" + company + "is:" + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            computeEmpWage("DMart", 20, 2, 10);
            computeEmpWage("Reliance", 10, 4, 20);
            Console.ReadKey();
        }


    }
}

