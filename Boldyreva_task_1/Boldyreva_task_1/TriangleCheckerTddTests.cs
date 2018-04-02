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
        [ExpectedException(typeof(Exception), "Must by exception for zero length")]
        public void tddZeroLengthLenTest1()
        {
            double result = Instance.checkBySides(0, 0, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Must by exception for zero length")]
        public void tddZeroLengthLenTest2()
        {
            double result = Instance.checkBySides(0, -10, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Must by exception for negative length")]
        public void tddNegativeLengthLenTest()
        {
            double result = Instance.checkBySides(2, 5, -10);
        }

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

        // Tests for coordinats
        [TestMethod]
        [ExpectedException(typeof(Exception), "Must by exception for zero length")]
        public void tddZeroLengthCoordTest()
        {
            double result = Instance.checkByCoord(0, 0, 0, 0, 4, 0);
        }//2 dots have the same coords
        
        
        [TestMethod]
        public void tddCorrectAllSidesEqualCoordTest()
        {
            double a = (4*Math.Sqrt(3))/2;
            double result = Instance.checkByCoord(0, 0, 4, 0, 2, a);
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
            double result = Instance.checkByCoord(0, 0, 3, 0, 0, 4);
            Assert.AreEqual(3, result, "Must be square angle triangle");
        }

        [TestMethod]
        public void tddCorrectUnknownAngleCoordTest()
        {
            double result = Instance.checkByCoord(0, 0, 5, 0, 6, 3);
            Assert.AreEqual(5, result, "Must be unknowne triangle");
        }
        //Test for out-of-born triangle useless because one of its sides will equal zero!!

        
        ///////
    }
}
