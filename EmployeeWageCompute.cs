using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeWageComputeArray
    {
        //constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpwageArray;

        public EmployeeWageComputeArray()
        {
            this.companyEmpwageArray = new CompanyEmpWage[5];
        }

        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpwageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numOfCompany++;
        }
        public void computeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpwageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpwageArray[i]));
                Console.WriteLine(this.companyEmpwageArray[i].toString());
            }
        }
            private int computeEmpWage(CompanyEmpWage companyEmpWage)
            {
                //local Variables
                int empHrs = 0;
                int totalEmpHrs = 0;
                int totalWorkingDays = 0;
                //Computation
                while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth  && totalWorkingDays < companyEmpWage.numOfWorkingDays)
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
                }
                return totalEmpHrs * companyEmpWage.empRatePerHour;
            }
    }
        public class CompanyEmpWage
        {
            public string company;
            public int empRatePerHour;
            public int numOfWorkingDays;
            public int maxHoursPerMonth;
            public int totalEmpWage;
            public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
            {
                this.company = company;
                this.empRatePerHour = empRatePerHour;
                this.numOfWorkingDays = numOfWorkingDays;
                this.maxHoursPerMonth = maxHoursPerMonth;
            }
            public void setTotalEmpWage(int totalEmpWage)
            {
                this.totalEmpWage = totalEmpWage;
            }


            public string toString()
            {
                return "total emp wage for company:" + this.company + "is:" + this.totalEmpWage;
            }
        }
    
}

       
        