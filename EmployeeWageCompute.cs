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
        static void Main(string[] args)
        {
            //Variables
            int empHrs = 0;
            int empWage = 0;

            //Predefined Random class for generating random values
            Random random = new Random();
            //Computation
            //Next method() 0-initial value,2-number of elemnets from 0
            int empCheck = random.Next(0,3);
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
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage :"+empWage);
            Console.Read();
        }
    }
}

