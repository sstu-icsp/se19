using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TriangleChecker;

namespace TestTriangleChecker
{
    [TestClass]
    public class TestsBeforeCoding
    {
        [TestMethod]
        public void TestSidesLength_3_3_3()
        {
            Assert.AreEqual("Triangle is equilateral", DefineTriangle.WithSidesLength(3.0, 3.0, 3.0));
        }

        [TestMethod]
        public void TestSidesLength_13_5_12()
        {
            Assert.AreEqual("Triangle is rightangled", DefineTriangle.WithSidesLength(13.0, 5.0, 12.0));
        }

        [TestMethod]
        public void TestSidesLength_4_11_7()
        {
            Assert.AreEqual("Triangle is degenerate", DefineTriangle.WithSidesLength(4.0, 11.0, 7.0));
        }

        [TestMethod]
        public void TestSidesLength_6_9_4()
        {
            Assert.AreEqual("Triangle is unknown", DefineTriangle.WithSidesLength(6.0, 9.0, 4.0));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSidesLength_3_0_3()
        {
            DefineTriangle.WithSidesLength(3.0, 0.0, 3.0);
        }
    }
}
