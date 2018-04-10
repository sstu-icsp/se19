using System;
using Task1_IntRange.UnitTestApproach;

namespace Task1_IntRange
{
    class Program
    {
        static void Main(string[] args)
        {
            IntRange ir = new IntRange(0, 0, IntRange.IntervalType.OPENED);
            ir.Length();
        }
    }
}
