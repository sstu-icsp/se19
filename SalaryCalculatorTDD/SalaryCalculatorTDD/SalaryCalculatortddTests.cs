using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SalaryCalculatorTDD
{
    [TestClass]
    public class SalaryCalculatorTddTests
    {
        private SalaryCalculatorTdd Instance;

        [TestInitialize]
        public void TestInitialize()
        {
            Instance = new SalaryCalculatorTdd();
        }

        [TestMethod]
        public void CorrectLevel()
        {
            double result = Instance.SalaryCalculating(7, 1, 1);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void PositiveLevel()
        {
            double result = Instance.SalaryCalculating(-1, 1, 1);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void PositiveBasicSalary()
        {
            double result = Instance.SalaryCalculating(1, -1, 1);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void PositiveBaseRatio()
        {
            double result = Instance.SalaryCalculating(1, 1, -1);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void CorrectBasicSalary()
        {
            double result = Instance.SalaryCalculating(1, 100000, 1);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void CorrectStandartCalculating()
        {
            double result = Instance.SalaryCalculating(2, 2, 2);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void CorrectAverageCalculating()
        {
            double result = Instance.SalaryCalculating(3, 2, 2);
            Assert.AreEqual(24, result);
        }
    }
}
