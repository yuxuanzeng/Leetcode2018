using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _275HIndexII
    {
        public int HIndex(int[] citations)
        {
            if (citations == null || citations.Length == 0)
            {
                return 0;
            }

            var lo = 0;
            var hi = citations.Length - 1;
            var h = citations[hi] / 2;
            var len = citations.Length;
            while (lo < hi)
            {
                var mid = lo + (hi - lo) / 2;
                if (h == len - mid)
                {
                    return h;
                }
                else if (h > len - mid)
                {
                    hi = mid - 1;
                }
                else
                {
                    lo = mid + 1;
                }
            }

            return len - lo;
        }
    }
}
