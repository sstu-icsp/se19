using System.Collections.Generic;

namespace Task1_IntRange.TDDApproach
{
    /// <summary>
    /// IntRange subclass that does include bounds
    /// </summary>
    public class IntRangeClosed : IntRange
    {

        public IntRangeClosed() : base() { }
        public IntRangeClosed(int left, int right) : base(left, right) { }
        public IntRangeClosed(float left, float right) : base(left, right) { }

        protected override void InitRange()
        {
            //Returning empty array if float bound is not 
            if (boundType == BoundType.Int)
            {
                values = new int[intMax - intMin + 1];
                int curr = intMin;
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = curr++;
                }
            }
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
 
    }
}
