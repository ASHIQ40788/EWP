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
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH=100;
        public static int computeEmpWage()
        {
            //local Variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            { 
                totalWorkingDays++;
                //Predefined Random class for generating random values
              Random random = new Random();

                //Computation
                //Next method() 0-initial value,2-number of elemnets from 0
                 int empCheck = random.Next(0,3);
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
          
                totalEmpHrs += empHrs ;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs : " + empHrs);
                //Console.WriteLine($"Day {day} EmployeeWage is = {empWage}");
                 //totalEmpWage += empWage;
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("total emp Wage:" +totalEmpWage);
            return totalEmpWage; 
        }
     static void Main(string[] args)
        {
            computeEmpWage();
            Console.ReadKey();
        }
        
    }
}

