using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    class SalaryCalculatorUnit
    {
        //Метод расчета зарплаты согласно требованиям
        public double CalculateSalary(int lvl, double baseSalary, double baseCoef)
        {
            try
            {
                //Выбрасывание исключения при значении любого параметра меньше 0
                if (lvl < 0 || baseSalary < 0 || baseCoef < 0)
                {
                    throw new Exception("Значение хотя бы одного из параметров меньше 0 не допускается");
                }
                //Выбрасывает исключение при значении lvl (уровень) больше 6
                if (lvl > 6)
                {
                    throw new Exception("Значение уровня больше 6 не допускается");
                }
                //Выбрасывает исключение при значении baseSalary (базовая зарплата) больше 50000 * lvl
                if (baseSalary > 50000 * lvl)
                {
                    throw new Exception("Введено некорректное значение базовой зарплаты");
                }

                //расчет зарплаты особым способом, если lvl в диапазоне от 2 (не включительно) до 5 (не включительно)
                if (lvl > 2 && lvl < 5)
                {
                    double salary = ((baseSalary * Math.Pow(baseCoef, lvl)) + (baseSalary * Math.Pow(baseCoef, lvl + 1))) / 2;
                    return salary;
                }
                //расчет зарплаты обычным способом
                else
                {
                    double salary = baseSalary * Math.Pow(baseCoef, lvl);
                    return salary;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Возникло исключение: " + ex.Message);
                return -1;
            }
        }
    }
}
