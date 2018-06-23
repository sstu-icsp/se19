using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using TriangleChecker;

namespace TestTriangleChecker
{
    [TestClass]
    public class TestsAfterCoding
    {
        [TestMethod]
        public void TestSidesLength_3p7_3p7_3p7()
        {
            Assert.AreEqual("Triangle is equilateral", DefineTriangle.WithSidesLength(3.7, 3.7, 3.7));
        }

        [TestMethod]
        public void TestPoitns_03_30_00()
        {
            Assert.AreEqual("Triangle is rightangled and isosceles", DefineTriangle.WithPoitns(
                new Point(3, 0),
                new Point(0, 3),
                new Point(0, 0)));
        }

        [TestMethod]
        public void TestPoitns_05_70_00()
        {
            Assert.AreEqual("Triangle is rightangled", DefineTriangle.WithPoitns(
                new Point(7, 0),
                new Point(0, 5),
                new Point(0, 0)));
        }

        [TestMethod]
        public void TestPoitns_05_70_10()
        {
            Assert.AreEqual("Triangle is unknown", DefineTriangle.WithPoitns(
                new Point(7, 0),
                new Point(0, 5),
                new Point(1, 0)));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSidesLength_3p7_m3p7_3p7()
        {
            DefineTriangle.WithSidesLength(3.7, -3.7, 3.7);
        }
    }
}
