using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    class SalaryCalculatorUnit
    {
        public double SalaryCalculating(int level, double basicSalary, double baseRatio)
        {
            try
            {
                //if (level < 0 || basicSalary < 0 || baseRatio < 0) throw new Exception("One of the parameters is less than zero");
                if (level > 6) throw new Exception("Level above 6");
                if (basicSalary > 50000 * level) throw new Exception("Uncorrect basic salary");
                if (level > 2 && level < 5)
                {
                    double resultSalary = AverageSalary(level, basicSalary, baseRatio);
                    return resultSalary;
                }
                else
                {
                    double resultSalary = StandartSalary(level, basicSalary, baseRatio);
                    return resultSalary;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }

        public double AverageSalary(int level, double basicSalary, double baseRatio)
        {
            double resultSalary = (basicSalary * Math.Pow(baseRatio, level)) + basicSalary * Math.Pow(baseRatio, level + 1) / 2;
            return resultSalary;
        }

        public double StandartSalary(int level, double basicSalary, double baseRatio)
        {
            double resultSalary = basicSalary * Math.Pow(baseRatio, level);
            return resultSalary;
        }
    }
}
