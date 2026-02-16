using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exp03_SOLID
{
   
        // This class has ONLY ONE responsibility:
        // It calculates salary.
        public class SalaryCalculator
        {
            public double CalculateSalary(double hours, double rate)
            {
                return hours * rate;
            }
        }

        // This class has ONLY ONE responsibility:
        // It prints salary.
        public class SalaryPrinter
        {
            public void Print(double salary)
            {
                Console.WriteLine("Salary: " + salary);
            }
        }
    }



