using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Boldyreva_task_1
{
    [TestClass]
    public class TraingleCheckerUnitTests
    {
        private TraingleCheckerUnit Instance;

        // Метод будет выполняться один раз перед запуском всех тестов.
        [ClassInitialize]
        public static void ClassInitialize(TestContext tc)
        {
            Console.WriteLine("Ready? Go!");
        }

        // Метод будет выполняться перед запуском каждого теста.
        [TestInitialize]
        public void TestInitialize()
        {
            Instance = new TraingleCheckerUnit();
        }

        
        [TestMethod]
        public void CorrectAllSidesEqualTest()
        {
            double result = Instance.checkBySides(8, 8, 8);
            Assert.AreEqual(1, result, "Must be all-sides-equal triange;");
        }

        [TestMethod]
        public void CorrectTwoSidesEqualTest()
        {
            double result = Instance.checkBySides(5,3,5);
            Assert.AreEqual(2, result, "Must be 2-sides-equal triangle");
        }

        [TestMethod]
        public void CorrectSquareAngleTest()
        {
            double result = Instance.checkBySides(3, 4, 5);
            Assert.AreEqual(3, result, "Must be square angle triangle");
        }
        
        [TestMethod]
        public void CorrectOutOfBornTriangleTest()
        {
            double result = Instance.checkBySides(5, 2, 1);
            Assert.AreEqual(4, result, "Must be out-of-born triangle");
        }

        //HOW TO DO THIS??
        //[TestMethod]
        //public void CorrectUnknownTriangleTest()
        //{
        //    double result = Instance.checkBySides();
        //    Assert.AreEqual(5, result, "Must be unknown triangle");
        //}

        [TestMethod]
        [ExpectedException(typeof(Exception), "Must by exception for negative length")]
        public void NegativeLengthTest()
        {
            double result = Instance.checkBySides(2, 0, -10);
        }
        



        ///////
    }
}


