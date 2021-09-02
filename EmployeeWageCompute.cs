using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWP
{
    class EmployeeWageCompute
    {
        static void Main(string[] args)
        {
            //constants
            int IS_PRESENT = 1; 

            //Predefined Random class for generating random values
            Random random = new Random();
            
            //Next method() 0-initial value,2-number of elemnets from 0
            int empCheck = random.Next(0, 2);

            //Selection statement
            if (empCheck == IS_PRESENT)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is Absent");
            Console.Read();
        }
    }
}

