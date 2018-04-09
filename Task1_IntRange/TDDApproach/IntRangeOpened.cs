using System;
using System.Collections.Generic;

namespace Task1_IntRange.TDDApproach
{
    /// <summary>
    /// IntRange subclass that doesn't include bounds
    /// </summary>
    public class IntRangeOpened : IntRange
    {
        public IntRangeOpened() : base() { }
        public IntRangeOpened(int left, int right) : base(left, right) { }
        public IntRangeOpened(float left, float right) : base(left, right) { }

        protected override void InitRange()
        {
            //If int bounds: shortening Range by 1 from each side. If interval is <= 1 return empty array.
            if (boundType == BoundType.Int)
            {
                if (intMax - intMin <= 1)
                {
                    values = new int[0];
                    return;
                }
                else
                {
                    intMin++;
                    intMax--;
                    values = new int[intMax - intMin + 1];
                    int curr = intMin;
                    for (int i = 0; i < values.Length; i++)
                    {
                        values[i] = curr++;
                    }
                }
            }
            //If float bounds: Adding int values starting form intMin until Max. If left bound is at int, moving left bound to exclude it.
            else if (boundType == BoundType.Float)
            {
                List<int> _values = new List<int>();
                if (Min - intMin == 0) intMin++;
                int curr = intMin;
                while (curr < Max)
                {
                    _values.Add(curr++);
                }
                values = _values.ToArray();
                return;
            }
        }

        public override bool ContainsFloat(float v)
        {
            return (v <= Min || v >= Max) ? false : true;
        }

    }
}
