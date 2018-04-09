using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorTDD
{
    class SalaryCalculatorTdd
    {
        public double SalaryCalculating(int level, double basicSalary, double baseRatio)
        {
            double result = 0;
            if (level > 6) return -1;
            else if (level < 0 || basicSalary < 0 || baseRatio < 0) return -1;
            else if (basicSalary > 50000 * level) return -1;
            else if (level > 2 && level < 5)
            {
                result = ((basicSalary * Math.Pow(baseRatio, level)) + (basicSalary * Math.Pow(baseRatio, level + 1)))/2;
                return result;
            }
            else
            {
                result = basicSalary * Math.Pow(baseRatio, level);
                return result;
            }
        }
    }
}
