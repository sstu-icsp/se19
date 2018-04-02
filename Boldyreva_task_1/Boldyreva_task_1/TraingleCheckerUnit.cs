﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boldyreva_task_1
{
    //variant #3 TraingleChecker
   /*
    * 1 - all-sides-equal triange;
    * 2 - 2-sides-equal triangle
    * 3 - 90deg-angle triangle
    * 4 - out-of-born triangle
    * 5 - unknown triangle
    */

    public class TraingleCheckerUnit
    {
        //Check for sides
        public int checkBySides(double a, double b, double c)
        {
            double a1 = Math.Pow(a,2), b1 = Math.Pow(b,2), c1 = Math.Pow(c,2); //for checking

            if (a < 0 || b < 0 || c < 0 )
                throw new Exception("Ошибка! Одна из сторон меньше нуля");
            if (a == 0 || b == 0 || c == 0)
                throw new Exception("Ошибка! Одна из сторон равна нулю");
            if (a > b + c || b > a + c || c > a + b)
                return 4;
            else if (a == b && a == c && b == c)
                return 1;
            else if (a1 == b1 + c1 || a1 == Math.Abs(b1 - c1) || b1 == a1 + c1 || b1 == Math.Abs(a1 - c1) || c1 == b1 + a1 || c1 == Math.Abs(b1 - a1))
                return 3;
            else if (a == b || a == c || b == c)
                return 2;
            else return 5;        
        }

        public int checkByCoord(double ax, double ay, double bx, double by, double cx, double cy)
        { 
            double ab, ac, bc;//length of sides
            ab = Math.Round(Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2)), 1);
            ac = Math.Round(Math.Sqrt(Math.Pow(cx - ax, 2) + Math.Pow(cy - ay, 2)), 1);
            bc = Math.Round(Math.Sqrt(Math.Pow(cx - bx, 2) + Math.Pow(cy - by, 2)), 1);

            double a1 = Math.Pow(ab, 2), b1 = Math.Pow(bc, 2), c1 = Math.Pow(ac, 2);//sauares for pifagor theory
            
            if (ab == 0 || ac == 0 || bc == 0)
                throw new Exception("Ошибка! Одна из сторон равна нулю");
            else if (ab == ac && ab == bc && bc == ac)
                return 1;
            else if (a1 == b1 + c1 || a1 == Math.Abs(b1 - c1) || b1 == a1 + c1 || b1 == Math.Abs(a1 - c1) || c1 == b1 + a1 || c1 == Math.Abs(b1 - a1))
                return 3;
            else if (ab == ac || ab == bc || bc == ac)
                return 2;
            else return 5;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey, teacher, leave those kids alone!");
            Console.ReadKey();
        }
    }
}
