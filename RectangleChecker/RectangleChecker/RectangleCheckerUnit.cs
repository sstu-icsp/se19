using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleChecker 
{
    public class RectangleCheckerUnit : Rectangle
    {
        public RectangleCheckerUnit(double Side_A, double Side_B, double angle)
            : base(Side_A, Side_B, angle)
        {
            
        }
        public RectangleCheckerUnit()
            : base()
        { 
            
        }
        public bool isRectangular() // проверяет, является ли прямоугольником
        {
            if (this.Angle == 90)
            {
                return true;
            }
            else return false;
        }
        public bool isDegenerate() // проверяет, является ли вырожденным
        {
            if (this.Angle == 180 || this.Angle == 0)
            {
                return true;
            }
            else return false;
        }
        public bool isRhombus() // проверяет, является ли ромбом
        {
            if (this.side_A == this.side_B)
            {
                return true;
            }
            else return false;
        }
        public bool isSquare() // проверяет, является ли квадратом
        {
            if (this.isRhombus() && this.Angle == 90)
            {
                return true;
            }
            else return false;
        }
        public bool isUnknown() //проверяет четырехугольник на неопределенность
        {
            if (this.isRhombus())
            {
                return false;
            }
            else
            {
                if (this.isRectangular())
                {
                    return false;
                }
                else
                {
                    if (this.isDegenerate())
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }

        }
    }
}
