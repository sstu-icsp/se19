using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1_IntRange.TDDApproach;

namespace Task1_IntRange
{
    class Program
    {
        static void Main(string[] args)
        {
            IntRangeOpened ir = new IntRangeOpened(0.99f, 1.01f);
           ir.IsEmpty();
        }
    }
}
