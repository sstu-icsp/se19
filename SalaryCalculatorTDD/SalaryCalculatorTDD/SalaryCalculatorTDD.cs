using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorTDD
{
    class SalaryCalculatorTdd
    {
        public double CalculateSalary(int lvl, double baseSalary, double baseCoef)
        {
            //реализует 1-5 тесты
            if (lvl < 0 || baseSalary < 0 || baseCoef < 0 || lvl > 6 || baseSalary > (lvl * 50000))
                return -1;
            
            //реализует 7 тест
            else if (lvl > 2 && lvl < 5)
            {
                return ((baseSalary * Math.Pow(baseCoef, lvl)) + (baseSalary * Math.Pow(baseCoef, lvl + 1))) / 2;
            }
            //реализует 6 тест
            else
            {
                return baseSalary * Math.Pow(baseCoef, lvl);
            }
        }
    }
}
