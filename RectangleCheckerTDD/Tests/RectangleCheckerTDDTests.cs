
/*RectangleChecker. Модуль для определения типа четырехугольника на основе 
пар значений длин противоположных сторон (считаем что противоположные стороны 
всегда равны) и угла между двумя соседними сторонами. 
Функциональность:
4.1. Определять Прямоугольный, Вырожденный или Неизвестный прямоугольник.
4.2. Определять Квадрат.
4.3. Выбрасывать исключение если длина хотя бы одной из сторон меньше нуля.
4.4. Определять Ромб.
4.5. Выбрасывать исключение если угол между двумя соседними сторонами меньше 
нуля или больше 360.
4.6. Определять Параллелограмм.
*/
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RectangleCheckerTDD;
/*
 1 - Прямоугольный
 2 - Вырожденный
 3 - Квадрат
 4 - Ромб
 5 - Параллелограмм
 6 - Неизвестный
 */
namespace Tests
{
    [TestClass]
    public class RectangleCheckerTDDTests
    {
        private RectangleChecker rect;

        [TestInitialize]
        public void TestInitialize()
        {
            rect = new RectangleChecker();
        }
 //4.1
 //Прямоугольный
        [TestMethod]
        public void Check_10_20_90_return1()
        {
            // arrange
            double a = 10;
            double b = 20;
            double c = 90;
            int expected = 1;
            // act
            int actual = rect.check(a,b,c);
            //assert
            Assert.AreEqual(expected, actual);
        }
//Вырожденный
        [TestMethod]
        public void Check_0_10_91_return2()
        {
            // arrange
            double a = 0;
            double b = 100;
            double c = 91;
            int expected = 2;
            // act
            int actual = rect.check(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_1_0_91_return2()
        {
            // arrange
            double a = 1;
            double b = 0;
            double c = 91;
            int expected = 2;
            // act
            int actual = rect.check(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Check_1_1_0_return2()
        {
            // arrange
            double a = 1;
            double b = 1;
            double c = 0;
            int expected = 2;
            // act
            int actual = rect.check(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Check_10_10_180_return2()
        {
            // arrange
            double a = 10;
            double b = 10;
            double c = 180;
            int expected = 2;
            // act
            int actual = rect.check(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Check_10_10_360_return2()
        {
            // arrange
            double a = 10;
            double b = 10;
            double c = 360;
            int expected = 2;
            // act
            int actual = rect.check(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }


//4.2
//Квадрат

        [TestMethod]
        public void Check_10_10_90_return3()
        {
            // arrange
            double a = 10;
            double b = 10;
            double c = 90;
            int expected = 3;
            // act
            int actual = rect.check(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }

//4.3
//Исключение, если одна из сторон меньше 0
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Длина одной из сторон меньше нуля")]
        public void Check_m1_10_20_ExcSideReturned()
        {
            // arrange
            double a = -1;
            double b = 10;
            double c = 20;
            // act
            int actual = rect.check(a, b, c);
        }
  

        [ExpectedException(typeof(ArgumentException), "Длина одной из сторон меньше нуля")]
        public void Check_10_m1_20_ExcSideReturned()
        {
            // arrange
            double a = 10;
            double b = -1;
            double c = 20;
            // act
            int actual = rect.check(a, b, c);
        }
//4.4
//Ромб

        [TestMethod]
        public void Check_20_20_80_return4()
        {
            // arrange
            double a = 20;
            double b = 20;
            double c = 80;
            int expected = 4;
            // act
            int actual = rect.check(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Check_20_20_181_return4()
        {
            // arrange
            double a = 20;
            double b = 20;
            double c = 181;
            int expected = 4;
            // act
            int actual = rect.check(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_20_20_179_return4()
        {
            // arrange
            double a = 20;
            double b = 20;
            double c = 179;
            int expected = 4;
            // act
            int actual = rect.check(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }
//4.5
//Исключение, если угол меньше 0 или больше 360

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Задан неверный угол")]
        public void Check_10_10_m1_ExcSideReturned()//Исключение
        {
            // arrange
            double a = 10;
            double b = 10;
            double c = -1;
            // act
            int actual = rect.check(a, b, c);
        }

         [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Задан неверный угол")]
        public void Check_10_10_361_ExcSideReturned()//Исключение
        {
            // arrange
            double a = 10;
            double b = 10;
            double c = 361;
            // act
            int actual = rect.check(a, b, c);
        }
//4.6
//Параллелограмм
        [TestMethod]
        public void Check_5_10_60_return5()
        {
            // arrange
            double a = 5;
            double b = 10;
            double c = 60;
            int expected = 5;
            // act
            int actual = rect.check(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Check_5_10_181_return5()
        {
            // arrange
            double a = 5;
            double b = 10;
            double c = 181;
            int expected = 5;
            // act
            int actual = rect.check(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_5_10_179_return5()
        {
            // arrange
            double a = 5;
            double b = 10;
            double c = 179;
            int expected = 5;
            // act
            int actual = rect.check(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
