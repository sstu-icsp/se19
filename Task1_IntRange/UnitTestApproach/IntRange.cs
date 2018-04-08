using System;

namespace Task1_IntRange.UnitTestApproach
{

    /// <summary>
    /// Stores integer numbers between the boundaries x and y of the interval
    /// </summary>
    public class IntRange
    {
        public float X { get { return start; } private set { } }
        public float Y { get { return end; } private set { } }
        public IntervalType TypeOfInterval { get { return intervalType; } private set { } }

        private float start, end;
        private int[] storedValues;
        private IntervalType intervalType;

        #region Constructors
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
        #endregion

        private void Initialize(float x, float y, IntervalType intervalType)
        {
            if (x <= y)
            {
                start = x;
                end = y;
            }
            else
            {
                start = y;
                end = x;
            }
            this.intervalType = intervalType;
            InitializeIntRangeArray();
        }

        private void InitializeIntRangeArray()
        {
            int currInt = (int)Math.Ceiling(start), lastInt = (int)Math.Floor(end);
            if (intervalType == IntervalType.OPENED)
            {
                    currInt++;
                    lastInt--;
            }
            int length = lastInt - currInt + 1;
            if (length < 0) length = 0;
            storedValues = new int[length];
            for (int i = 0; currInt <= lastInt; i++)
            {
                storedValues[i] = currInt;
                currInt++;
            }
        }

        public bool IsEmpty()
        {
            return storedValues.Length == 0;
        }

        public int Length()
        {
            return storedValues.Length;
        }

        public bool Contains(int number)
        {
            if (IsEmpty())
                return false;
            return number >= storedValues[0] && number <= storedValues[storedValues.Length - 1];
        }

        public bool Intersects(IntRange otherRange)
        {
            if (IsEmpty() || otherRange.IsEmpty())
                return false;
            return (start >= otherRange.start && start <= otherRange.end) ||
                (end >= otherRange.start && end <= otherRange.end);
        }

        public enum IntervalType { CLOSED, OPENED }
    }
}
