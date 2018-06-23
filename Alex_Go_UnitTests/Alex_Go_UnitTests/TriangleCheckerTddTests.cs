using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Alex_Go_UnitTests
{
    /*
     * 1 - all-sides-equal triangle
     * 2 - 2-sides-equal triangle
     * 3 - right triangle
     * 4 - out-of-born triangle
     * 5 - unknown triangle
    */

    [TestClass]
    public class TriangleCheckerTddTests
    {
        private TriangleCheckerTdd Instance;
        
        [TestInitialize]
        public void TestInitialize()
        {
            Instance = new TriangleCheckerTdd();
        }

        //Tests for sides
        [TestMethod]
        [ExpectedException(typeof(Exception), "Must by exception for negative length")]
        public void tddNegativeLengthTest()
        {
            double result = Instance.checkBySides(2, 3, -5);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Must by exception for zero length")]
        public void tddZeroLengthTest1()
        {
            double result = Instance.checkBySides(0, 0, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Must by exception for zero length")]
        public void tddZeroLengthTest2()
        {
            double result = Instance.checkBySides(0, 0, 0);
        }

        [TestMethod]
        public void tddCorrectAllSidesEqualLengthTest()
        {
            double result = Instance.checkBySides(2, 2, 2);
            Assert.AreEqual(1, result, "Must be all-sides-equal triange");
        }

        [TestMethod]
        public void tddCorrectTwoSidesEqualLengthTest()
        {
            double result = Instance.checkBySides(3, 1, 3);
            Assert.AreEqual(2, result, "Must be 2-sides-equal triangle");
        }

        [TestMethod]
        public void tddCorrectSquareAngleLenTest()
        {
            double result = Instance.checkBySides(3, 4, 5);
            Assert.AreEqual(3, result, "Must be square angle triangle");
        }

        [TestMethod]
        public void tddCorrectOutOfBornTriangleLengthTest()
        {
            double result = Instance.checkBySides(1, 3, 4);
            Assert.AreEqual(4, result, "Must be out-of-born triangle");
        }

        [TestMethod]
        public void tddCorrectUnknownTriangleLengthTest()
        {
            double result = Instance.checkBySides(1, 3, 5);
            Assert.AreEqual(5, result, "Must be unknown triangle");
        }

        // Tests for coordinats
        [TestMethod]
        [ExpectedException(typeof(Exception), "Must by exception for zero length")]
        public void tddZeroLengthCoordsTest1()
        {
            double result = Instance.checkByCoords(0, 0, 0, 0, 4, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Must by exception for zero length")]
        public void tddZeroLengthCoordsTest2()
        {
            double result = Instance.checkByCoords(0, 0, 0, 0, 0, 0);
        }

        [TestMethod]
        public void tddCorrectAllSidesEqualCoordsTest()
        {
            double a = (6 * Math.Sqrt(3)) / 2;
            double result = Instance.checkByCoords(0, 0, 6, 0, 3, a);
            Assert.AreEqual(1, result, "Must be all-sides-equal triange");
        }

        [TestMethod]
        public void tddCorrectTwoSidesEqualCoordsTest()
        {
            double result = Instance.checkByCoords(0, 0, 0, 1, 1, 0);
            Assert.AreEqual(2, result, "Must be 2-sides-equal triangle");
        }

        [TestMethod]
        public void tddCorrectSquareAngleCoordsTest()
        {
            double result = Instance.checkByCoords(0, 0, 0, 3, 4, 0);
            Assert.AreEqual(3, result, "Must be square angle triangle");
        }

        [TestMethod]
        public void tddCorrectOutOfBornCoordsTest()
        {
            double result = Instance.checkByCoords(0, 1, 0, 2, 0, 5);
            Assert.AreEqual(4, result, "Must be out-of-born triangle");
        }

        [TestMethod]
        public void tddCorrectUnknownAngleCoordsTest()
        {
            double result = Instance.checkByCoords(0, 0, 5, 0, 6, 3);
            Assert.AreEqual(5, result, "Must be unknowne triangle");
        }
    }
}
