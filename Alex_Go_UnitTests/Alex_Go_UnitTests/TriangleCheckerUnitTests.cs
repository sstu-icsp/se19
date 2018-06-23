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
    public class TriangleCheckerUnitTests
    {
        private TriangleCheckerUnit Instance;
        
        [TestInitialize]
        public void TestInitialize()
        {
            Instance = new TriangleCheckerUnit();
        }

        //Tests for sides
        [TestMethod]
        [ExpectedException(typeof(Exception), "Must by exception for negative length")]
        public void NegativeLengthTest()
        {
            double result = Instance.checkBySides(2, 3, -5);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Must by exception for zero length")]
        public void ZeroLengthTest1()
        {
            double result = Instance.checkBySides(0, 0, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Must by exception for zero length")]
        public void ZeroLengthTest2()
        {
            double result = Instance.checkBySides(0, 0, 0);
        }

        [TestMethod]
        public void CorrectAllSidesEqualLengthTest()
        {
            double result = Instance.checkBySides(3, 3, 3);
            Assert.AreEqual(1, result, "Must be all-sides-equal triangle");
        }

        [TestMethod]
        public void CorrectTwoSidesEqualLengthTest()
        {
            double result = Instance.checkBySides(3, 6, 6);
            Assert.AreEqual(2, result, "Must be 2-sides-equal triangle");
        }

        [TestMethod]
        public void CorrectRightAngleLengthTest()
        {
            double result = Instance.checkBySides(3, 4, 5);
            Assert.AreEqual(3, result, "Must be right triangle");
        }

        [TestMethod]
        public void CorrectOutOfBornTriangleLengthTest()
        {
            double result = Instance.checkBySides(1, 2, 3);
            Assert.AreEqual(4, result, "Must be out-of-born triangle");
        }

        [TestMethod]
        public void CorrectUnknownTriangleLengthTest()
        {
            double result = Instance.checkBySides(3, 5, 7);
            Assert.AreEqual(5, result, "Must be unknown triangle");
        }

        //Tests for coordinates
        [TestMethod]
        public void CorrectAllSidesEqualCoordsTest()
        {
            double a = (6 * Math.Sqrt(3)) / 2;
            double result = Instance.checkByCoords(0, 0, 6, 0, 3, a);
            Assert.AreEqual(1, result, "Must be all-sides-equal triange");
        }

        [TestMethod]
        public void CorrectTwoSidesEqualCoordsTest()
        {
            double result = Instance.checkByCoords(0, 0, 4, 0, 2, 5);
            Assert.AreEqual(2, result, "Must be 2-sides-equal triangle");
        }

        [TestMethod]
        public void CorrectRightAngleCoordsTest()
        {
            double result = Instance.checkByCoords(0, 0, 0, 3, 4, 0);
            Assert.AreEqual(3, result, "Must be right triangle");
        }

        [TestMethod]
        public void CorrectOutOfBornCoordsTest()
        {
            double result = Instance.checkByCoords(0, 1, 0, 2, 0, 5);
            Assert.AreEqual(4, result, "Must be out-of-born triangle");
        }

        [TestMethod]
        public void CorrectUnknownCoordsTest()
        {
            double result = Instance.checkByCoords(0, 0, 3, 0, 0, 5);
            Assert.AreEqual(5, result, "Must be unknown triangle");
        }
    }
}
