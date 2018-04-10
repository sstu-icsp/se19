using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RectangleChecker;

namespace RectangleCheckerTddTests
{
    [TestClass]
    public class RectangleCheckerTddTests
    {
        [TestMethod]
        public void Tdd_Correct_Rectangular()
        {
            RectangleCheckerTdd test = new RectangleCheckerTdd(200, 300, 90);
            bool result = test.isRectangular();
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Tdd_Correct_Not_Rectangular()
        {
            RectangleCheckerTdd test = new RectangleCheckerTdd(200, 300, 89.00000001);
            bool result = test.isRectangular();
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void Tdd_Correct_Degenerate()
        {
            RectangleCheckerTdd test1 = new RectangleCheckerTdd(200, 300, 0);
            RectangleCheckerTdd test2 = new RectangleCheckerTdd(200, 300, 180);
            bool result1 = test1.isDegenerate();
            bool result2 = test2.isDegenerate();
            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
        }
        [TestMethod]
        public void Tdd_Correct_Not_Degenerate()
        {
            RectangleCheckerTdd test = new RectangleCheckerTdd(200, 300, 45.0000001);
            bool result = test.isDegenerate();
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void Tdd_Correct_Unknown()
        {
            RectangleCheckerTdd test = new RectangleCheckerTdd(200, 300, 44.9999999);
            bool result = test.isUnknown();
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Tdd_Correct_Not_Unknown()
        {
            RectangleCheckerTdd test1 = new RectangleCheckerTdd(200, 200, 44.9999999);
            RectangleCheckerTdd test2 = new RectangleCheckerTdd(200, 300, 90);
            RectangleCheckerTdd test3 = new RectangleCheckerTdd(0.0000001, 300, 0);
            RectangleCheckerTdd test4 = new RectangleCheckerTdd(200, 30, 180);
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
        public void Tdd_Correct_Square()
        {
            RectangleCheckerTdd test = new RectangleCheckerTdd(2000000, 2000000, 90.000000);
            bool result = test.isSquare();
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Tdd_Correct_Not_Square()
        {
            RectangleCheckerTdd test1 = new RectangleCheckerTdd(2000000, 2000000, 90.0000001);
            RectangleCheckerTdd test2 = new RectangleCheckerTdd(2000000, 2000000.00001, 90.000000);
            RectangleCheckerTdd test3 = new RectangleCheckerTdd(2000000.99999, 2000000, 90.00000022);
            bool result1 = test1.isSquare();
            bool result2 = test2.isSquare();
            bool result3 = test3.isSquare();
            Assert.AreEqual(false, result1);
            Assert.AreEqual(false, result2);
            Assert.AreEqual(false, result3);
        }
        [TestMethod]
        public void Tdd_Correct_Rhombus()
        {
            RectangleCheckerTdd test = new RectangleCheckerTdd(0, 0, 0);
            bool result = test.isRhombus();
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Tdd_Correct_Not_Rhombus()
        {
            RectangleCheckerTdd test = new RectangleCheckerTdd(0, 0.0000001, 0);
            bool result = test.isRhombus();
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Tdd_Correct_Error_Negative_Side()
        {
            RectangleCheckerTdd test1 = new RectangleCheckerTdd(-1, -0.000001, 25);
            RectangleCheckerTdd test2 = new RectangleCheckerTdd(-1, 0.000001, 25);
            RectangleCheckerTdd test3 = new RectangleCheckerTdd(1, -0.000001, 25);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Tdd_Correct_Error_Owerflow_Angle()
        {
            RectangleCheckerTdd test1 = new RectangleCheckerTdd(1, 2, -0.00000001);
            RectangleCheckerTdd test2 = new RectangleCheckerTdd(1, 2, 360.000000001);
        }
    }
}
