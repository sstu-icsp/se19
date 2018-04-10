using System;

namespace Task1_IntRange.UnitTestApproach
{

    /// <summary>
    /// Stores integer numbers between the boundaries x and y of the interval
    /// </summary>
    public class IntRange
    {
        public float X { get; private set; }
        public float Y { get; private set; }
        public IntervalType TypeOfInterval { get; private set; }

        private int startInt, endInt; //first left and right ints at interval

        /// <param name = "x" >Left boundary of the interval</param>
        /// <param name="y">Right boundary of the interval</param>
        /// <param name="type">CLOSED - includes boundaries, OPENED - excludes boundaries</param>
        public IntRange(float x, float y, IntervalType type = IntervalType.CLOSED)
        {
            Initialize(x, y, type);
        }

        /// <param name = "x" >Left boundary of the interval</param>
        /// <param name="y">Right boundary of the interval</param>
        /// <param name="type">CLOSED - includes boundaries, OPENED - excludes boundaries</param>
        public IntRange(int x, int y, IntervalType type = IntervalType.CLOSED)
        {
            Initialize(x, y, type);
        }

        private void Initialize(float x, float y, IntervalType intervalType)
        {
            if (x <= y)
            {
                X = x;
                Y = y;
            }
            else
            {
                X = y;
                Y = x;
            }
            startInt = (int)Math.Ceiling(X);
            endInt = (int)Math.Floor(Y);
            TypeOfInterval = intervalType;
        }

        public bool IsEmpty()
        {
            if (startInt > endInt || (TypeOfInterval == IntervalType.OPENED && X == Y))
                return true;
            return false;
        }

        public int Length()
        {
            int curr = startInt;
            if (TypeOfInterval == IntervalType.CLOSED)
            {
                while (curr <= Y)
                {
                    curr++;
                }
            }
            else if (TypeOfInterval == IntervalType.OPENED)
            {
                while (curr < Y)
                {
                    curr++;
                }
                if (X - startInt == 0 && X!=Y)
                    return curr - startInt - 1;
            }
             
            return curr - startInt;
        }

        public bool Contains(int number)
        {
            return ContainsFloat(number);
        }

        public bool ContainsFloat(float number)
        {
            if (TypeOfInterval == IntervalType.CLOSED)
                return number >= X && number <= Y;
            else
                return number > X && number < Y;
        }

        public bool Intersects(IntRange otherRange)
        {
            if (IsEmpty() || otherRange.IsEmpty())
                return false;
            return (ContainsFloat(otherRange.X) || ContainsFloat(otherRange.Y)) 
                && (otherRange.ContainsFloat(X) || otherRange.ContainsFloat(Y))
                || (X == otherRange.X && Y == otherRange.Y);
        }

        public enum IntervalType { CLOSED, OPENED }
    }
}
