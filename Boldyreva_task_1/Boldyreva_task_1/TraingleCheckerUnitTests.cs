using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Boldyreva_task_1
{
    [TestClass]
    public class TraingleCheckerUnitTests
    {
        private TraingleCheckerUnit Instance;

        // Метод будет выполняться перед запуском каждого теста.
        [TestInitialize]
        public void TestInitialize()
        {
            Instance = new TraingleCheckerUnit();
        }
        
        //Tests for sides
        [TestMethod]
        public void CorrectAllSidesEqualLenTest()
        {
            double result = Instance.checkBySides(8, 8, 8);
            Assert.AreEqual(1, result, "Must be all-sides-equal triange;");
        }

        [TestMethod]
        public void CorrectTwoSidesEqualLenTest()
        {
            double result = Instance.checkBySides(5,3,5);
            Assert.AreEqual(2, result, "Must be 2-sides-equal triangle");
        }

        [TestMethod]
        public void CorrectSquareAngleLenTest()
        {
            double result = Instance.checkBySides(3, 4, 5);
            Assert.AreEqual(3, result, "Must be square angle triangle");
        }
        
        [TestMethod]
        public void CorrectOutOfBornTriangleLenTest()
        {
            double result = Instance.checkBySides(5, 2, 1);
            Assert.AreEqual(4, result, "Must be out-of-born triangle");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Must by exception for negative length")]
        public void NegativeLengthLenTest()
        {
            double result = Instance.checkBySides(2, 0, -10);
        }

       // Tests for coordinats
        [TestMethod]
        public void CorrectAllSidesEqualCoordTest()
        {
            double result = Instance.checkByCoord(0, 0, 1, 0, 1.2, (Math.Pow(3, 0.5))/2);
            Assert.AreEqual(1, result, "Must be all-sides-equal triange;");
        }

        [TestMethod]
        public void CorrectTwoSidesEqualCoordTest()
        {
            double result = Instance.checkByCoord(0, 0, 0, 2, 2, 0);
            Assert.AreEqual(2, result, "Must be 2-sides-equal triangle");
        }

        [TestMethod]
        public void CorrectSquareAngleCoordTest()
        {
            double result = Instance.checkByCoord(0, 3, 3, 0, 0, 0);
            Assert.AreEqual(3, result, "Must be square angle triangle");
        }

        [TestMethod]
        public void CorrectOutOfBornTriangleCoordTest()
        {
            double result = Instance.checkByCoord(2, 2, 3, 2, 2, 2);
            Assert.AreEqual(4, result, "Must be out-of-born triangle");
        }

        ///////
    }
}


