using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1_IntRange.UnitTestApproach;

namespace UnitTests
{
    [TestClass]
    public class IntRangeClosedIntervalTests
    {

        #region IsEmpty()
        [TestMethod]
        public void Range_Float_Empty()
        {
            IntRange ir = new IntRange(0.6f, 0.6f);
            Assert.AreEqual(true, ir.IsEmpty());
        }

        [TestMethod]
        public void Range0to0_NotEmpty()
        {
            IntRange ir = new IntRange(0, 0);
            Assert.AreEqual(false, ir.IsEmpty());
        }

        [TestMethod]
        public void Range0to1_NotEmpty()
        {
            IntRange ir = new IntRange(0, 1);
            Assert.AreEqual(false, ir.IsEmpty());
        }

        [TestMethod]
        public void RangeNegative_NotEmpty()
        {
            IntRange ir = new IntRange(-1, -1);
            Assert.AreEqual(false, ir.IsEmpty());
        }
        #endregion

        #region Length()

        [TestMethod]
        public void Range0to0_Length()
        {
            IntRange ir = new IntRange(0, 0);
            Assert.AreEqual(1, ir.Length());
        }

        [TestMethod]
        public void Range_Float_Length3()
        {
            IntRange ir = new IntRange(0.2f, 3.3f);
            Assert.AreEqual(3, ir.Length());
        }

        [TestMethod]
        public void Range_Negative()
        {
            IntRange ir = new IntRange(-10f, -5f);
            Assert.AreEqual(6, ir.Length());
        }

        #endregion

        #region Contains()

        [TestMethod]
        public void Range0to0_NotContains1()
        {
            IntRange ir = new IntRange(0, 0);
            Assert.AreEqual(false, ir.Contains(1));
        }

        [TestMethod]
        public void Range0to1_Contains01()
        {
            IntRange ir = new IntRange(0, 1);
            Assert.AreEqual(true, ir.Contains(0));
            Assert.AreEqual(true, ir.Contains(1));
        }

        [TestMethod]
        public void Range1to20_Contains7AndBounds()
        {
            IntRange ir = new IntRange(1, 20);
            Assert.AreEqual(true, ir.Contains(7));
            Assert.AreEqual(true, ir.Contains(1));
            Assert.AreEqual(true, ir.Contains(20));
        }

        [TestMethod]
        public void RangeNegative_Contains()
        {
            IntRange ir = new IntRange(-20, 0);
            Assert.AreEqual(true, ir.Contains(-20));
            Assert.AreEqual(true, ir.Contains(-7));
            Assert.AreEqual(true, ir.Contains(0));
        }

        [TestMethod]
        public void Range_ContainsFloat()
        {
            IntRange ir = new IntRange(0.2f, 0.8f);
            Assert.AreEqual(true, ir.ContainsFloat(0.5f));
            Assert.AreEqual(true, ir.ContainsFloat(0.2f));
            Assert.AreEqual(true, ir.ContainsFloat(0.8f));
            Assert.AreEqual(false, ir.ContainsFloat(0.19f));
            Assert.AreEqual(false, ir.ContainsFloat(0.81f));
        }
        #endregion

        #region Intersects()

        [TestMethod]
        public void RangeNegative_IntersectsLeftBoundNegative()
        {
            IntRange ir1 = new IntRange(-20, 0);
            IntRange ir2 = new IntRange(-21, -20);
            Assert.AreEqual(true, ir1.Intersects(ir2));
        }

        [TestMethod]
        public void RangeNegative_IntersectsRightBound()
        {
            IntRange ir1 = new IntRange(-20, 0);
            IntRange ir2 = new IntRange(20, 0);
            Assert.AreEqual(true, ir1.Intersects(ir2));
        }

        [TestMethod]
        public void Range_Equal_Intersects()
        {
            IntRange ir1 = new IntRange(0, 5);
            IntRange ir2 = new IntRange(5, 0);
            Assert.AreEqual(true, ir1.Intersects(ir2));
        }

        [TestMethod]
        public void Range_NotIntersects()
        {
            IntRange ir1 = new IntRange(0, 5);
            IntRange ir2 = new IntRange(8, 6);
            Assert.AreEqual(false, ir1.Intersects(ir2));
        }

        [TestMethod]
        public void Range_00Intersects()
        {
            IntRange ir1 = new IntRange(0, 0);
            IntRange ir2 = new IntRange(0, 0);
            Assert.AreEqual(true, ir1.Intersects(ir2));
        }

        #endregion
    }
}
