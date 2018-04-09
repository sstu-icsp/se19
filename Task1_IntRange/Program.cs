using Task1_IntRange.TDDApproach;

namespace Task1_IntRange
{
    class Program
    {
        static void Main(string[] args)
        {
            IntRange ir = new IntRangeClosed(1f, 2.99f);
            IntRange ir2 = new IntRangeOpened(2.99f, 4f);
            ir.Intersects(ir2);
        }
    }
}
