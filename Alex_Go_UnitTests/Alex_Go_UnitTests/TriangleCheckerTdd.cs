using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alex_Go_UnitTests
{
    /*
     * 1 - all-sides-equal triangle
     * 2 - 2-sides-equal triangle
     * 3 - right triangle
     * 4 - out-of-born triangle
     * 5 - unknown triangle
    */

    public class TriangleCheckerTdd
    {
        public int checkBySides(double a, double b, double c)
        {
            double a1 = Math.Pow(a, 2), b1 = Math.Pow(b, 2), c1 = Math.Pow(c, 2);
            int result = 0;

            if (a < 0 || b < 0 || c < 0)
                throw new Exception("One of side is less zero");
            if (a == 0 || b == 0 || c == 0)
                throw new Exception("One of side is equal zero");
            if (a == b + c || b == a + c || c == a + b)
                result = 4;
            else if (a == b && a == c && b == c)
                result = 1;
            else if (a1 == b1 + c1 || a1 == Math.Abs(b1 - c1) || b1 == a1 + c1 || b1 == Math.Abs(a1 - c1) || c1 == b1 + a1 || c1 == Math.Abs(b1 - a1))
                result = 3;
            else if (a == b || a == c || b == c)
                result = 2;
            else result = 5;
            return result;
        }

        public int checkByCoords(double ax, double ay, double bx, double by, double cx, double cy)
        {
            double ab, ac, bc;
            ab = Math.Round(Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2)), 1);
            ac = Math.Round(Math.Sqrt(Math.Pow(cx - ax, 2) + Math.Pow(cy - ay, 2)), 1);
            bc = Math.Round(Math.Sqrt(Math.Pow(cx - bx, 2) + Math.Pow(cy - by, 2)), 1);

            double a1 = Math.Pow(ab, 2), b1 = Math.Pow(bc, 2), c1 = Math.Pow(ac, 2);
            int result = 0;
            
            if (ab == 0 || ac == 0 || bc == 0)
                throw new Exception("One of side is equal zero");
            if (ab == ac + bc || ac == ab + bc || bc == ab + ac)
                result = 4;
            else if (ab == ac && ab == bc && bc == ac)
                result = 1;
            else if (a1 == b1 + c1 || a1 == Math.Abs(b1 - c1) || b1 == a1 + c1 || b1 == Math.Abs(a1 - c1) || c1 == b1 + a1 || c1 == Math.Abs(b1 - a1))
                result = 3;
            else if (ab == ac || ab == bc || bc == ac)
                result = 2;
            else result = 5;
            return result;
        }
    }
}
