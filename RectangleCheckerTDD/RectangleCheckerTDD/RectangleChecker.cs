using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleCheckerTDD
{
   public class RectangleChecker
    {
        public int check(double a, double b, double c)
        {
            if (a < 0 || b < 0) throw new ArgumentException("Длина одной из сторон меньше нуля");
            if (c < 0 || c > 360) throw new ArgumentException("Задан неверный угол");
            if (c > 180) c = 360 - c;
            if (c == 90 && a != b) return 1;
            if (a == 0 || b == 0 || c == 0 || c == 180) return 2;
            if (a == b && c == 90) return 3;
            if (a == b) return 4;
            else return 5;
        }
    }
}
