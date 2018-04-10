using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1_IntRange.UnitTestApproach;

namespace UnitTests
{
    [TestClass]
    public class IntRangeOpenedIntervalTests
    {
        #region IsEmpty()

        [TestMethod]
        public void Range0to0_Empty()
        {
            IntRange ir = new IntRange(0, 0, IntRange.IntervalType.OPENED);
            Assert.AreEqual(true, ir.IsEmpty());
        }

        [TestMethod]
        public void Range0to1_Empty()
        {
            IntRange ir = new IntRange(0, 1, IntRange.IntervalType.OPENED);
            Assert.AreEqual(false, ir.IsEmpty());
        }

        [TestMethod]
        public void RangeNgative_NotEmpty()
        {
            IntRange ir = new IntRange(-1, 1, IntRange.IntervalType.OPENED);
            Assert.AreEqual(false, ir.IsEmpty());
        }

        [TestMethod]
        public void Range0to2_NotEmpty()
        {
            IntRange ir = new IntRange(0, 2, IntRange.IntervalType.OPENED);
            Assert.AreEqual(false, ir.IsEmpty());
        }
        #endregion

        #region Length()

        [TestMethod]
        public void Range0to0_Length_is0()
        {
            IntRange ir = new IntRange(0, 0, IntRange.IntervalType.OPENED);
            Assert.AreEqual(0, ir.Length());
        }

        [TestMethod]
        public void Range_Float_Length_is3()
        {
            IntRange ir = new IntRange(0.2f, 3.3f);
            Assert.AreEqual(3, ir.Length());
        }

        [TestMethod]
        public void Range_Negative()
        {
            IntRange ir = new IntRange(-10f, -5f, IntRange.IntervalType.OPENED);
            Assert.AreEqual(4, ir.Length());
        }
        #endregion

        #region Contains()

        [TestMethod]
        public void Range0to1_NotContains1()
        {
            IntRange ir = new IntRange(0, 1, IntRange.IntervalType.OPENED);
            Assert.AreEqual(false, ir.Contains(1));
        }

        [TestMethod]
        public void Range0to1_NotContains01()
        {
            IntRange ir = new IntRange(0, 1, IntRange.IntervalType.OPENED);
            Assert.AreEqual(false, ir.Contains(0));
            Assert.AreEqual(false, ir.Contains(1));
        }

        [TestMethod]
        public void Range1to20Closed_Contains7AndNotBounds()
        {
            IntRange ir = new IntRange(1, 20, IntRange.IntervalType.OPENED);
            Assert.AreEqual(true, ir.Contains(7));
            Assert.AreEqual(false, ir.Contains(1));
            Assert.AreEqual(false, ir.Contains(20));
        }

        [TestMethod]
        public void RangeNegative_Contains()
        {
            IntRange ir = new IntRange(-20, 0);
            Assert.AreEqual(true, ir.Contains(-19));
            Assert.AreEqual(true, ir.Contains(-7));
            Assert.AreEqual(true, ir.Contains(-1));
        }

        [TestMethod]
        public void Range_ContainsFloat()
        {
            IntRange ir = new IntRange(0.2f, 0.8f, IntRange.IntervalType.OPENED);
            Assert.AreEqual(true, ir.ContainsFloat(0.5f));
            Assert.AreEqual(false, ir.ContainsFloat(0.2f));
            Assert.AreEqual(false, ir.ContainsFloat(0.8f));
            Assert.AreEqual(false, ir.ContainsFloat(0.19f));
            Assert.AreEqual(false, ir.ContainsFloat(0.81f));
        }
        #endregion

        #region Intersects()

        [TestMethod]
        public void RangeNegative_NotIntersectsLeftBoundNegative1()
        {
            IntRange ir1 = new IntRange(-20, 0, IntRange.IntervalType.OPENED);
            IntRange ir2 = new IntRange(-21, -20);
            Assert.AreEqual(false, ir1.Intersects(ir2));
        }

        [TestMethod]
        public void RangeNegative_NotIntersectsLeftBoundNegative()
        {
            IntRange ir1 = new IntRange(-20, 0);
            IntRange ir2 = new IntRange(-21, -20, IntRange.IntervalType.OPENED);
            Assert.AreEqual(false, ir1.Intersects(ir2));
        }

        [TestMethod]
        public void IntersectsLeftBoundBothOpen()
        {
            IntRange ir1 = new IntRange(-20, 1, IntRange.IntervalType.OPENED);
            IntRange ir2 = new IntRange(-22, -18, IntRange.IntervalType.OPENED);
            Assert.AreEqual(true, ir1.Intersects(ir2));
        }

        [TestMethod]
        public void NotIntersectsLeftBoundBothOpened()
        {
            IntRange ir1 = new IntRange(-20, 1, IntRange.IntervalType.OPENED);
            IntRange ir2 = new IntRange(-22, -19, IntRange.IntervalType.OPENED);
            Assert.AreEqual(true, ir1.Intersects(ir2));
        }
        [TestMethod]
        public void IntersectsRightBoundBothOpened()
        {
            IntRange ir1 = new IntRange(-20, 1, IntRange.IntervalType.OPENED);
            IntRange ir2 = new IntRange(20, -1, IntRange.IntervalType.OPENED);
            Assert.AreEqual(true, ir1.Intersects(ir2));
        }

        [TestMethod]
        public void NotIntersectsRightBoundBothOpened()
        {
            IntRange ir1 = new IntRange(-20, 1, IntRange.IntervalType.OPENED);
            IntRange ir2 = new IntRange(20, 0, IntRange.IntervalType.OPENED);
            Assert.AreEqual(true, ir1.Intersects(ir2));
        }
        [TestMethod]
        public void Range_Equal_Intersects()
        {
            IntRange ir1 = new IntRange(0, 5, IntRange.IntervalType.OPENED);
            IntRange ir2 = new IntRange(5, 0, IntRange.IntervalType.OPENED);
            Assert.AreEqual(true, ir1.Intersects(ir2));
        }

        [TestMethod]
        public void Range_NotIntersects()
        {
            IntRange ir1 = new IntRange(0, 5, IntRange.IntervalType.OPENED);
            IntRange ir2 = new IntRange(8, 6, IntRange.IntervalType.OPENED);
            Assert.AreEqual(false, ir1.Intersects(ir2));
        }

        [TestMethod]
        public void Range_00NotIntersects()
        {
            IntRange ir1 = new IntRange(0, 0, IntRange.IntervalType.OPENED);
            IntRange ir2 = new IntRange(0, 0, IntRange.IntervalType.OPENED);
            Assert.AreEqual(false, ir1.Intersects(ir2));
        }

        #endregion
    }
}
