using System;
using System.Drawing;

namespace TriangleChecker
{
    public class DefineTriangle
    {
        public static string WithSidesLength(double sideA, double sideB, double sideC)
        {
            string result;
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Length of all the sides must be positive!");
            }
            else if (sideA == sideB && sideB == sideC)
            {
                result = "Triangle is equilateral";
            }
            else if (sideA == sideB || sideB == sideC || sideC == sideA)
            {
                result = "Triangle is isosceles";
            }
            else if (Math.Pow(sideA, 2.0) == Math.Pow(sideB, 2.0) + Math.Pow(sideC, 2.0)
                || Math.Pow(sideB, 2.0) == Math.Pow(sideA, 2.0) + Math.Pow(sideC, 2.0)
                || Math.Pow(sideC, 2.0) == Math.Pow(sideB, 2.0) + Math.Pow(sideA, 2.0))
            {
                result = "Triangle is rightangled";
            }
            else if (sideA == sideB + sideC
                || sideB == sideA + sideC
                || sideC == sideB + sideA)
            {
                result = "Triangle is degenerate";
            }
            else
            {
                result = "Triangle is unknown";
            }
            return result;
        }

        public static string WithPoitns(Point pointA, Point pointB, Point pointC)
        {
            double sideA = DefineLength(pointA, pointB);
            double sideB = DefineLength(pointC, pointB);
            double sideC = DefineLength(pointA, pointC);

            // in case if triange is rightangled and isosceles
            bool rightangled = Math.Round(Math.Pow(sideA, 2.0), 5) == Math.Round(Math.Pow(sideB, 2.0), 5) + Math.Round(Math.Pow(sideC, 2.0), 5)
                || Math.Round(Math.Pow(sideB, 2.0), 5) == Math.Round(Math.Pow(sideA, 2.0), 5) + Math.Round(Math.Pow(sideC, 2.0), 5)
                || Math.Round(Math.Pow(sideC, 2.0), 5) == Math.Round(Math.Pow(sideB, 2.0), 5) + Math.Round(Math.Pow(sideA, 2.0), 5);
            bool isosceles = sideA == sideB || sideB == sideC || sideC == sideA;
            if (isosceles && rightangled)
            {
                return "Triangle is rightangled and isosceles";
            }
            return DefineTriangle.WithSidesLength(sideA, sideB, sideC);
        }

        private static double DefineLength(Point pointA, Point pointB)
        {
            return Math.Sqrt(Math.Pow(pointA.X - pointB.X, 2.0) + Math.Pow(pointA.Y - pointB.Y, 2.0));
        }
    }
}
