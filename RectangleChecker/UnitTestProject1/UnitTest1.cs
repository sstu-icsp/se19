using RectangleChecker;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class RectangleCheckerUnitTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),"Длина одной из сторон меньше нуля")]
        public void Check_a_b10_corner90_ExcSideReturned()//Исключение
        {
            RectangleCheckerUnit rc1 = new RectangleCheckerUnit(-1, 1, 30);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Задан неверный угол")]
        public void Check_a_b10_corner50_ExcSideReturned()//Исключение
        {
            RectangleCheckerUnit rc1 = new RectangleCheckerUnit(10, 1, -50);
        }
       
        [TestMethod]
        public void Check_a10_b10_corner361_ExcCornerReturned()// Исключение
        {
            // arrange
            double a = 10.0;
            double b = 10.0;
            double c = 361.0;
            string expected = "Задан неверный угол";
            // act
            try
            {
                RectangleCheckerUnit rc1 = new RectangleCheckerUnit(a, b, c);
            }
            //assert
            catch (ArgumentException ae)
            {
                Assert.AreEqual(expected, ae.Message);
            }

        }

        [TestMethod]
        public void Check_a0_b10_corner90_1Returned()// Вырожденный
        {
            // arrange
            double a = 0.0;
            double b = 10.0;
            double c = 90.0;
            int expected = 1;
            // act

            RectangleCheckerUnit rc1 = new RectangleCheckerUnit(a, b, c);
            //assert

            int actual = rc1.check();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_a10_b10_corner90_2Returned()// КВАДРАТ
        {
            // arrange
            double a = 10.0;
            double b = 10.0;
            double c = 90.0;
            int expected = 2;
            // act
            RectangleCheckerUnit rc1 = new RectangleCheckerUnit(a, b, c);
            int actual = rc1.check();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Check_a10_b10_corner110_3Returned()//РОМБ
        {
            // arrange
            double a = 10.0;
            double b = 10.0;
            double c = 110.0;
            int expected = 3;
            // act
            RectangleCheckerUnit rc1 = new RectangleCheckerUnit(a, b, c);
            int actual = rc1.check();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Check_a12_b10_corner110_4Returned()// ПРЯМОУГОЛЬНИК
        {
            // arrange
            double a = 12.0;
            double b = 10.0;
            double c = 90.0;
            int expected = 4;
            // act
            RectangleCheckerUnit rc1 = new RectangleCheckerUnit(a, b, c);
            int actual = rc1.check();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Check_a12_b10_corner110_5Returned()//ПАРАЛЛЕЛОГРАММ
        {
            // arrange
            double a = 12.0;
            double b = 10.0;
            double c = 110.0;
            int expected = 5;
            // act
            RectangleCheckerUnit rc1 = new RectangleCheckerUnit(a, b, c);
            int actual = rc1.check();
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
