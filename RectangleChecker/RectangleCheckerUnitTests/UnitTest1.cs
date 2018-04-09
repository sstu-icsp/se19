using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RectangleChecker;

namespace RectangleCheckerUnitTests
{
    [TestClass]
    public class RectangleCheckerUnitTests
    {
        [TestMethod]
        public void Correct_Rectangular()
        {
            RectangleCheckerUnit test = new RectangleCheckerUnit(12, 40, 90);
            bool result = test.isRectangular();
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Correct_Not_Rectangular()
        {
            RectangleCheckerUnit test = new RectangleCheckerUnit(12, 40, 91);
            bool result = test.isRectangular();
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void Correct_Not_Degenerate()
        {
            RectangleCheckerUnit test1 = new RectangleCheckerUnit(12, 40, 1);
            RectangleCheckerUnit test2 = new RectangleCheckerUnit(12, 40, 179);
            bool result1 = test1.isDegenerate();
            bool result2 = test2.isDegenerate();
            Assert.AreEqual(false, result1);
            Assert.AreEqual(false, result2);
        }
        [TestMethod]
        public void Correct_Rhombus()
        {
            RectangleCheckerUnit test = new RectangleCheckerUnit(40, 40, 65);
            bool result = test.isRhombus();
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Correct_Not_Rhombus()
        {
            RectangleCheckerUnit test = new RectangleCheckerUnit(40, 41, 65);
            bool result = test.isRhombus();
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void Correct_Square()
        {
            RectangleCheckerUnit test = new RectangleCheckerUnit(40, 40, 90);
            bool result = test.isSquare();
            Assert.AreEqual(true, result);
        }
        public void Correct_Not_Square()
        {
            RectangleCheckerUnit test1 = new RectangleCheckerUnit(40, 4, 90);
            RectangleCheckerUnit test2 = new RectangleCheckerUnit(40, 40, 91);
            bool result1 = test1.isSquare();
            bool result2 = test2.isSquare();
            Assert.AreEqual(false, result1);
            Assert.AreEqual(false, result2);
        }
        [TestMethod]
        public void Correct_Unknown()
        {
            RectangleCheckerUnit test = new RectangleCheckerUnit(300, 40, 91);
            bool result = test.isUnknown();
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Correct_Not_Unknown()
        {
            RectangleCheckerUnit test1 = new RectangleCheckerUnit(40, 40, 92);
            RectangleCheckerUnit test2 = new RectangleCheckerUnit(40, 41, 90);
            RectangleCheckerUnit test3 = new RectangleCheckerUnit(40, 41, 0);
            RectangleCheckerUnit test4 = new RectangleCheckerUnit(40, 40, 180);
            bool result1 = test1.isUnknown();
            bool result2 = test2.isUnknown();
            bool result3 = test3.isUnknown();
            bool result4 = test4.isUnknown();
            Assert.AreEqual(false, result1);
            Assert.AreEqual(false, result2);
            Assert.AreEqual(false, result3);
            Assert.AreEqual(false, result4);
        }
        [TestMethod]
        public void Add_Void_Rectangle()
        {
            RectangleCheckerUnit test = new RectangleCheckerUnit();
            bool result1 = test.isDegenerate();
            bool result2 = test.isRhombus();
            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
        }
        [TestMethod]
        public void Error_Add_Negative_Side()
        {
            RectangleCheckerUnit test = new RectangleCheckerUnit(-40, -40, 90);
        }
        [TestMethod]
        public void Error_Add_Wrong_Angle()
        {
            RectangleCheckerUnit test1 = new RectangleCheckerUnit(40, 40, -1);
            RectangleCheckerUnit test2 = new RectangleCheckerUnit(40, 40, 361);
        }
    }
}
