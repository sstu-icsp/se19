//RectangleChecker. Модуль для определения типа четырехугольника на основе пар значений длин противоположных сторон 
//(считаем что противоположные стороны всегда равны) и угла между двумя соседними сторонами. Функциональность:
//4.1. Определять Прямоугольный, Вырожденный или Неизвестный прямоугольник.
//4.2. Определять Квадрат.
//4.3. Выбрасывать исключение если длина хотя бы одной из сторон меньше нуля.
//4.4. Определять Ромб.
//4.5. Выбрасывать исключение если угол между двумя соседними сторонами меньше нуля или больше 360.
//4.6. Определять Параллелограмм.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleChecker
{
    public class RectangleCheckerUnit
    {

        private double a;
        private double b;
        private double corner;

        public RectangleCheckerUnit(double a, double b, double corner)
        {
            if (a >= 0 && b >= 0)
            {
                this.a = a;
                this.b = b;
            }
            else
            {
                throw new ArgumentException("Длина одной из сторон меньше нуля");
            }

            if (corner >= 0 && corner <= 360)
                this.corner = corner;
            else
            {
                throw new ArgumentException("Задан неверный угол");
            }
        }


        public int check()
        {

            if (a == 0 || b == 0 || corner == 0 || corner == 360) return 1;/// ВЫРОЖДЕННЫЙ
            else
                if (a == b)
                {
                    if (corner == 90) return 2;// КВАДРАТ
                    else return 3;//РОМБ
                }
                else
                {
                    if (corner == 90) return 4;// ПРЯМОУГОЛЬНИК
                    else return 5;//ПАРАЛЛЕЛОГРАММ
                }
            //return 6;//НЕИЗВЕСТНЫЙ(НЕВОЗМОЖНЫЙ)
        }
    }
}
