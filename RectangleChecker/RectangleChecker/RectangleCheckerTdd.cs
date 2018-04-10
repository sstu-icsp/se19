using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleChecker
{
    public class RectangleCheckerTdd : RectangleTdd
    {
        public RectangleCheckerTdd(double side_a, double side_b, double angle)
            : base(side_a, side_b, angle)
        { 
            
        }
        public bool isRectangular() // проверка на прямоугольник
        {
            if (this.Angle == 90)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isDegenerate() // проверка на вырожденность
        {
            if (this.Angle == 0 || this.Angle == 180)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isUnknown() // проверка на неопределенность
        {
            if (this.isDegenerate() || this.isRectangular() || this.isRhombus())
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool isSquare() // проверка на квадрат
        {
            if (this.Side_a == this.Side_b && this.Angle == 90)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isRhombus() // проверка на ромб
        {
            if (this.Side_a == this.Side_b)
            {
                return true;
            }
            return false;
        }
    }
}
