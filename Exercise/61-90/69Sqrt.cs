using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _69Sqrt
    {
        public int MySqrt(int x)
        {
            if (x == 0)
            {
                return 0;
            }
            return MySqrt(x, 1, x);
        }

        private int MySqrt(int x, int lo, int hi)
        {
            var mid = lo + (hi - lo) / 2;
            if (mid == lo)
            {
                return mid;
            }
            Int64 res = (Int64)mid * (Int64)mid;
            if (res == x)
            {
                return mid;
            }
            else if (res > x)
            {
                return MySqrt(x, lo, mid);
            }
            else
            {
                return MySqrt(x, mid, hi);
            }
        }
    }
}
