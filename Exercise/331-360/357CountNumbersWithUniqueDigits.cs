using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _357CountNumbersWithUniqueDigits
    {
        public int CountNumbersWithUniqueDigits(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            var ret = 0;
            for (var i = 1; i <= (n > 10 ? 10 : n); i++)
            {
                ret += helper(i);
            }
            return ret;
        }

        private int helper(int n)
        {
            if (n == 1)
            {
                return 9 + 1;
            }
            //if (n == 2)
            //{
            //    return 9 * 8 + 1 * 9;
            //}
            //if (n == 3)
            //{
            //    return 9 * 8 * 7 + 2 * 9 * 8; 
            //}
            //if (n == 4)
            //{
            //    return 9 * 8 * 7 * 6 + 3 * 9 * 8 * 7;
            //}
            var nonZeroNumberFactor = 9;
            var zeroNumberFactor = n - 1;
            var ret = nonZeroNumberFactor + zeroNumberFactor;
            for (var i = 1; i < n; i++)
            {
                nonZeroNumberFactor = nonZeroNumberFactor * (10 - i - 1);
                zeroNumberFactor = zeroNumberFactor * (10 - i);
                ret = nonZeroNumberFactor + zeroNumberFactor;
            }
            return ret;
        }
    }
}
