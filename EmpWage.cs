﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld1
{
    internal class EmpWage
    {
    public static void DailyEmployeeWage()
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int Getattendance = random.Next(0, 2);
            if (Getattendance == IS_FULL_TIME)
            {
                empHrs = 8;

            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("EmpWage:" + empWage);
        }

    }
}
