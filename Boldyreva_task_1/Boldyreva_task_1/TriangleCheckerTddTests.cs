using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Boldyreva_task_1
{
    [TestClass]
    public class TriangleCheckerTddTests
    {
        private TriangleCheckerTdd Instance;

        // Метод будет выполняться перед запуском каждого теста.
        [TestInitialize]
        public void TestInitialize()
        {
            Instance = new TriangleCheckerTdd();
        }

        //Tests for sides
        [TestMethod]
        public void tddCorrectAllSidesEqualLenTest()
        {
            double result = Instance.checkBySides(2, 2, 2);
            Assert.AreEqual(1, result, "Must be all-sides-equal triange;");
        }

        [TestMethod]
        public void tddCorrectTwoSidesEqualLenTest()
        {
            double result = Instance.checkBySides(6, 1, 6);
            Assert.AreEqual(2, result, "Must be 2-sides-equal triangle");
        }

        [TestMethod]
        public void tddCorrectSquareAngleLenTest()
        {
            double result = Instance.checkBySides(3, 4, 5);
            Assert.AreEqual(3, result, "Must be square angle triangle");
        }

        [TestMethod]
        public void CorrectOutOfBornTriangleLenTest1()
        {
            double result = Instance.checkBySides(10, 3, 1);
            Assert.AreEqual(4, result, "Must be out-of-born triangle");
        }

        [TestMethod]
        public void tddCorrectOutOfBornTriangleLenTest2()
        {
            double result = Instance.checkBySides(1, 6, 1);
            Assert.AreEqual(4, result, "Must be out-of-born triangle");
        }

        [TestMethod]
        public void tddCorrectOutOfBornTriangleLenTest3()
        {
            double result = Instance.checkBySides(1, 1, 0);
            Assert.AreEqual(4, result, "Must be out-of-born triangle");
        }

        [TestMethod]
        public void tddCorrectOutOfBornTriangleLenTest4()
        {
            double result = Instance.checkBySides(0, 0, 0);
            Assert.AreEqual(4, result, "Must be out-of-born triangle");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Must by exception for negative length")]
        public void tddNegativeLengthLenTest()
        {
            double result = Instance.checkBySides(2, 0, -10);
        }

        // Tests for coordinats
        [TestMethod]
        public void tddCorrectAllSidesEqualCoordTest()
        {
            double result = Instance.checkByCoord(0, 0, 0, 4, 4, 0);
            Assert.AreEqual(1, result, "Must be all-sides-equal triange;");
        }

        [TestMethod]
        public void tddCorrectTwoSidesEqualCoordTest()
        {
            double result = Instance.checkByCoord(0, 0, 0, 1, 1, 0);
            Assert.AreEqual(2, result, "Must be 2-sides-equal triangle");
        }

        [TestMethod]
        public void tddCorrectSquareAngleCoordTest()
        {
            double result = Instance.checkByCoord(0, 3, 3, 0, 0, 0);
            Assert.AreEqual(3, result, "Must be square angle triangle");
        }

        [TestMethod]
        public void tddCorrectOutOfBornTriangleCoordTest()
        {
            double result = Instance.checkByCoord(2, 2, 3, 2, 2, 2);
            Assert.AreEqual(4, result, "Must be out-of-born triangle");
        }

        ///////
    }
}
