using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class EmployeeWageCompute
    {
        static void Main(string[] args)
        {
            //constants
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            
            //Variables
            int empHrs = 0;
            int empWage = 0;

            //Predefined Random class for generating random values
            Random random = new Random();
            //Computation
            //Next method() 0-initial value,2-number of elemnets from 0
            int empCheck = random.Next(0,3);

            //Selection statement
            if (empCheck == IS_PART_TIME)
            {
                empHrs = 4;
            }
              
            else if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage :"+empWage);
            Console.Read();
        }
    }
}

