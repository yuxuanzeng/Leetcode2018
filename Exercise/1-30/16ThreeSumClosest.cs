using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _16ThreeSumClosest
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            var res = 0;
            var delta = Int32.MaxValue;
            var n = nums.OrderBy(num => num).ToList();
            for (var i = 0; i < n.Count - 2; i++)
            {
                var lo = i + 1;
                var hi = n.Count - 1;
                while (lo < hi)
                {
                    var sum = n[i] + n[lo] + n[hi];
                    var curDelta = Math.Abs(sum-target);
                    if (sum == target)
                    {
                        return target;
                    }
                    else if (sum < target)
                    {
                        //while (lo < hi && n[lo] == n[lo + 1]) lo++;
                        lo++;
                    }
                    else
                    {
                        //while (lo < hi && n[hi] == n[hi - 1]) hi--;
                        hi--;
                    }
                    if (curDelta < delta)
                    {
                        res = sum;
                        delta = curDelta;
                    }
                }
            }

            return res;
        }
    }
}
