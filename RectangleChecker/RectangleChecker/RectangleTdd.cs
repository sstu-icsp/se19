using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleChecker
{
    public class RectangleTdd
    {
        protected double Side_a;
        protected double Side_b;
        protected double Angle;
        public RectangleTdd(double side_a, double side_b, double angle)
        {
            if (side_a < 0 || side_b < 0)
            {
                throw new Exception("Negative value of side.");
            }
            else
            {
                if (angle < 0 || angle > 360)
                {
                    throw new Exception("Owerflow value of angle.");
                }
                else
                {
                    Side_a = side_a;
                    Side_b = side_b;
                    Angle = angle;
                }
            }
            
        }
    }
}
