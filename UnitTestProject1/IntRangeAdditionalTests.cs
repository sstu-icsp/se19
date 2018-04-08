using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1_IntRange.UnitTestApproach;

namespace UnitTests
{
    [TestClass]
    public class IntRangeAdditionalTests
    {
        [TestMethod]
        public void Float_LimitValues_Length3()
        {
            IntRange ir = new IntRange(0.0001f, 3.9999f);
            Assert.AreEqual(3, ir.Length());
        }
    }
}
