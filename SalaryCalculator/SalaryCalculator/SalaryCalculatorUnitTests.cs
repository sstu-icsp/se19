using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SalaryCalculator
{
    [TestClass]
    public class SalaryCalculatorUnitTests
    {
        private SalaryCalculatorUnit scConst;

        [TestInitialize]
        public void TestInitialize()
        {
            scConst = new SalaryCalculatorUnit();
        }

        [TestMethod]
        public void NegativeLevel()
        {
            double result = scConst.SalaryCalculating(-1, 1, 1);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void NegativeBasicSalary()
        {
            double result = scConst.SalaryCalculating(1, -1, 1);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void NegativeBaseRatio()
        {
            double result = scConst.SalaryCalculating(1, 1, -1);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void LevelСorrectness()
        {
            double result = scConst.SalaryCalculating(7, 1, 1);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void BasicSalaryCorrectness()
        {
            double result = scConst.SalaryCalculating(1, 100000, 1);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void CorrectStandartSalary()
        {
            double result = scConst.SalaryCalculating(2, 2, 2);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void CorrectAverageSalary()
        {
            double result = scConst.SalaryCalculating(3, 2, 2);
            Assert.AreEqual(24, result);
        }
    }
}
