using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1_IntRange.TDDApproach;



namespace TDDUnitTests
{
    //IntRange. Модуль для хранения промежутка целых положительных чисел, ограниченном значениями X и Y.
    [TestClass]
    public class IntRangeTddTests
    {
        //1.1. Свойство IsEmpty проверяет является ли промежуток пустым.
        #region IsEmpty()
        [TestMethod]
        public void TestIsEmptyTrue()
        {
            IntRange ir = new IntRangeClosed();
            Assert.AreEqual(true, ir.IsEmpty());
        }

        [TestMethod]
        public void TestIsEmptyFalse()
        {
            IntRange ir = new IntRangeClosed(1, 6);
            Assert.AreEqual(false, ir.IsEmpty());
        }
        #endregion

        //1.2. Свойство Length возвращает длину промежутка – количество целых чисел, входящих в него.
        #region Length()
        [TestMethod]
        public void TestZeroLength()
        {
            IntRange ir = new IntRangeClosed();
            Assert.AreEqual(0, ir.Length());
        }

        [TestMethod]
        public void Test1Length()
        {
            IntRange ir = new IntRangeClosed(1, 1);
            Assert.AreEqual(1, ir.Length());
        }

        [TestMethod]
        public void TestLength()
        {
            IntRange ir = new IntRangeClosed(15, 20);//15, 16, 17, 18, 19, 20
            Assert.AreEqual(6, ir.Length());
        }
        #endregion

        //1.3. Метод Contains(int number) проверяет входит ли указанное число в промежуток.
        #region Contains()
        [TestMethod]
        public void TestContainsFalse()
        {
            IntRange ir = new IntRangeClosed(15, 20);
            Assert.AreEqual(false, ir.Contains(21));
            Assert.AreEqual(false, ir.Contains(14));
        }
        [TestMethod]
        public void TestContainsTrue()
        {
            IntRange ir = new IntRangeClosed(15, 20);
            Assert.AreEqual(true, ir.Contains(17));
        }
        [TestMethod]
        public void TestContainsBordersTrue()
        {
            IntRange ir = new IntRangeClosed(15, 20);
            Assert.AreEqual(true, ir.Contains(15));
            Assert.AreEqual(true, ir.Contains(20));
        }
        #endregion

        //1.4. Метод Intersects(IntRange range) проверяет пересекается ли промежуток с другим промежутком.
        #region Intersects()
        [TestMethod]
        public void TestIntersectsFalse()
        {
            IntRange ir = new IntRangeClosed(15, 20);
            IntRange ir2 = new IntRangeClosed(21, 28);
            Assert.AreEqual(false, ir.Intersects(ir2));
            Assert.AreEqual(false, ir2.Intersects(ir));
        }

        [TestMethod]
        public void TestIntersectsTrue()
        {
            IntRange ir = new IntRangeClosed(17, 25);
            IntRange ir2 = new IntRangeClosed(17, 25);
            Assert.AreEqual(true, ir.Intersects(ir2));
            Assert.AreEqual(true, ir2.Intersects(ir));
        }

        [TestMethod]
        public void TestIntersectsTrueBorders()
        {
            IntRange ir = new IntRangeClosed(17, 25);
            IntRange irRight = new IntRangeClosed(25, 26);
            IntRange irLeft = new IntRangeClosed(25, 26);
            Assert.AreEqual(true, ir.Intersects(irRight));
            Assert.AreEqual(true, irRight.Intersects(ir));
            Assert.AreEqual(true, ir.Intersects(irLeft));
            Assert.AreEqual(true, irLeft.Intersects(ir));
        }
        #endregion

        //1.5. Поддерживаются разные типы промежутков: отрезок либо интервал, что влияет на все свойства и методы.
        //Testing intervals
        #region IntRangeOpened

        #region IsEmpty()
        [TestMethod]
        public void TestOpenedIsEmptyTrue()
        {
            IntRange ir = new IntRangeOpened();
            Assert.AreEqual(true, ir.IsEmpty());
        }
        [TestMethod]
        public void TestOpenedIsEmptyTrueWhenMinEqualsMax()
        {
            IntRange ir = new IntRangeOpened(1, 1);
            Assert.AreEqual(true, ir.IsEmpty());
        }
        [TestMethod]
        public void TestOpenedIsEmptyTrueWhenAdjacent()
        {
            IntRange ir = new IntRangeOpened(1, 2);
            Assert.AreEqual(true, ir.IsEmpty());
        }
        [TestMethod]
        public void TestOpenedIsEmptyFalse()
        {
            IntRange ir = new IntRangeOpened(1, 3);
            Assert.AreEqual(false, ir.IsEmpty());
        }
        #endregion

        #region Length()
        [TestMethod]
        public void TestOpenedLengthZero()
        {
            IntRange ir = new IntRangeOpened(1, 1);
            Assert.AreEqual(0, ir.Length());
            ir = new IntRangeOpened(1, 0);
            Assert.AreEqual(0, ir.Length());
        }
        [TestMethod]
        public void TestOpenedLength1()
        {
            IntRange ir = new IntRangeOpened(1, 3);
            Assert.AreEqual(1, ir.Length());
        }
        [TestMethod]
        public void TestOpenedLength()
        {
            IntRange ir = new IntRangeOpened(1, 5);
            Assert.AreEqual(3, ir.Length());
        } 
        #endregion

        #region Contains()
        [TestMethod]
        public void TestOpenedContainsBordersFalse()
        {
            IntRange ir = new IntRangeOpened(1, 3);
            Assert.AreEqual(false, ir.Contains(1));
            Assert.AreEqual(false, ir.Contains(3));
        }
        #endregion

        #region Intersects()
        [TestMethod]
        public void TestOpenedIntersectsBordersFalse()
        {
            IntRange ir = new IntRangeOpened(-10, -2);
            IntRange irRight = new IntRangeOpened(-2, 0);
            IntRange irLeft = new IntRangeOpened(-15, -10);
            Assert.AreEqual(false, ir.Intersects(irRight));
            Assert.AreEqual(false, ir.Intersects(irLeft));
        }
        #endregion

        #endregion

        //1.6. Поддерживаются отрицательные значения X и Y.
        #region Negative
        [TestMethod]
        public void TestLengthNegativeClosed()
        {
            IntRange ir = new IntRangeClosed(-5, -2);
            Assert.AreEqual(4, ir.Length());
        }

        [TestMethod]
        public void TestLengthNegativeOpened()
        {
            IntRange ir = new IntRangeOpened(-5, -2);
            Assert.AreEqual(2, ir.Length());
        }
        #endregion

        //1.7. Поддерживаются дробные значения.
        #region Float
        [TestMethod]
        public void TestFloatIsEmptyTrue()
        {
            IntRange ir = new IntRangeClosed(0.1f, 0.5f);
            Assert.AreEqual(true, ir.IsEmpty());
            ir = new IntRangeOpened(0f, 1f);
            Assert.AreEqual(true, ir.IsEmpty());
        }

        [TestMethod]
        public void TestFloatIsEmptyFalse()
        {
            IntRange ir = new IntRangeClosed(0.1f, 1.1f);
            Assert.AreEqual(false, ir.IsEmpty());
            ir = new IntRangeOpened(-0.01f, 1.01f);
            Assert.AreEqual(false, ir.IsEmpty());
        }
        [TestMethod]
        public void TestFloatIsEmptyFalseAroundInt()
        {
            IntRange ir = new IntRangeOpened(0.99f, 1.01f);
            Assert.AreEqual(false, ir.IsEmpty());
            ir = new IntRangeClosed(0.99f, 1.01f);
            Assert.AreEqual(false, ir.IsEmpty());
        }
        [TestMethod]
        public void TestFloatZeroLength()
        {
            IntRange ir = new IntRangeClosed(0.0003f, 0.003f);
            Assert.AreEqual(0, ir.Length());
            ir = new IntRangeOpened(1.5f, 1.5f);
            Assert.AreEqual(0, ir.Length());
        }
        
        [TestMethod]
        public void TestFloatLength()
        {
            IntRange ir = new IntRangeClosed(1.01f, 2.99f);
            Assert.AreEqual(1, ir.Length());
            ir = new IntRangeOpened(0.99f, 3.01f);
            Assert.AreEqual(3, ir.Length());
        }

        [TestMethod]
        public void TestClosedFloatIntersectsLimit()
        {
            IntRange ir = new IntRangeClosed(1f, 2.99f); 
            IntRange ir2 = new IntRangeClosed(3.01f, 4f);
            Assert.AreEqual(false, ir.Intersects(ir2));
            ir2 = new IntRangeClosed(3.0f, 4f);
            Assert.AreEqual(false, ir.Intersects(ir2));
            ir2 = new IntRangeClosed(2.99f, 4f);
            Assert.AreEqual(true, ir.Intersects(ir2));
        }

        [TestMethod]
        public void TestClosedAndOpenedFloatIntersectsLimit()
        {
            IntRange ir = new IntRangeClosed(1f, 2.99f);
            IntRange ir2 = new IntRangeOpened(3.01f, 4f);
            Assert.AreEqual(false, ir.Intersects(ir2));
            ir2 = new IntRangeOpened(2.99f, 4f);
            Assert.AreEqual(false, ir.Intersects(ir2));
            ir2 = new IntRangeOpened(2.98f, 4f);
            Assert.AreEqual(true, ir.Intersects(ir2));
        }

        [TestMethod]
        public void TestOpenedFloatIntersectsLimit()
        {
            IntRange ir = new IntRangeOpened(1f, 2.99f);
            IntRange ir2 = new IntRangeOpened(3.01f, 4f);
            Assert.AreEqual(false, ir.Intersects(ir2));
            ir2 = new IntRangeOpened(2.99f, 4f);
            Assert.AreEqual(false, ir.Intersects(ir2));
            ir2 = new IntRangeOpened(2.98f, 4f);
            Assert.AreEqual(true, ir.Intersects(ir2));
        }

        #endregion
    }
}
