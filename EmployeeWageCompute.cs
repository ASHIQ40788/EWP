using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeWageCompute
    {
        //constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public EmployeeWageCompute(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void computeEmpWage()
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

            totalEmpWage = totalEmpHrs * this.empRatePerHour;
            Console.WriteLine("total emp Wage for company:" + company + "is:" + totalEmpWage);
 
        }
        public string toString()
        {
            return "total emp wage for company:" + this.company + "is:" + this.totalEmpWage;
        }
        static void Main(string[] args)
        {
            EmployeeWageCompute dMart = new EmployeeWageCompute("DMart", 20, 2, 10);
            EmployeeWageCompute reliance = new EmployeeWageCompute("Reliance", 10, 4, 20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
            Console.ReadKey();
        }


    }
}

