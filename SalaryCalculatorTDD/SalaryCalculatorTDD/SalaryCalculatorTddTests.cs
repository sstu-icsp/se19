using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SalaryCalculatorTDD
{
    [TestClass]
    public class SalaryCalculatorTddTests
    {
        private SalaryCalculatorTdd sc;

        [TestInitialize]
        public void TestInitialize()
        {
            sc = new SalaryCalculatorTdd();
        }

        //значение уровня меньше нуля
        [TestMethod]
        public void LevelIsLessThanZero()
        {
            double result = sc.CalculateSalary(-1, 1, 1);
            Assert.AreEqual(-1, result);
        }

        //значение базовой зарплаты меньше нуля
        [TestMethod]
        public void BaseSalaryIsLessThanZero()
        {
            double result = sc.CalculateSalary(1, -1, 1);
            Assert.AreEqual(-1, result);
        }

        //значение базового коэффициента меньше нуля
        [TestMethod]
        public void BaseCoefficientIsLessThanZero()
        {
            double result = sc.CalculateSalary(1, 1, -1);
            Assert.AreEqual(-1, result);
        }

        //значение уровня больше 6
        [TestMethod]
        public void LevelIsGreaterThan6()
        {
            double result = sc.CalculateSalary(7, 1, 1);
            Assert.AreEqual(-1, result);
        }

        //значение базового коэффициента больше (уровень * 50000)
        [TestMethod]
        public void BasicSalaryIsGreaterThen50000Level()
        {
            double result = sc.CalculateSalary(2, 100001, 1);
            Assert.AreEqual(-1, result);
        }

        //стандартный расчет
        [TestMethod]
        public void StandartCalculation()
        {
            double result = sc.CalculateSalary(2, 100, 10);
            double myResult = 10000;
            Assert.AreEqual(myResult, result);
        }

        //расчет при значении уровня в диапазоне от 2 (не включительно) до 5 (не включительно)
        [TestMethod]
        public void SpecialCalculation()
        {
            double result = sc.CalculateSalary(4, 30, 2);
            double myResult = 720;
            Assert.AreEqual(myResult, result);
        }
    }
}

