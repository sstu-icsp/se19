using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleChecker
{
    public class Rectangle
    {
        protected double side_A; // смежная сторона А
        protected double side_B; // смежная сторона В
        protected double Angle; // угол между ними
        public Rectangle(double Side_A, double Side_B, double angle)
        {
            if (Side_A < 0 || Side_B < 0)
            {
                throw new Exception("Tne negative value side");
            }
            else
            {
                if (angle < 0 || angle > 360)
                {
                    throw new Exception("The size of the angle went beyond the boundaries");
                }
                else
                {
                    side_A = Side_A;
                    side_B = Side_B;
                    Angle = angle;
                }
            }
        }
        public Rectangle()
        {
            side_A = 0;
            side_B = 0;
            Angle = 0;
        }
    }
}
