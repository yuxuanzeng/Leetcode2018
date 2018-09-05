using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _18FourSum
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            var res = new List<IList<int>>();
            if (nums == null || nums.Length < 4)
            {
                return res;
            }
            var n = nums.OrderBy(num => num).ToList();
            var len = n.Count;
            if (n[0] + n[1] + n[2] + n[3] > target
                || n[len - 1] + n[len - 2] + n[len - 3] + n[len - 4] < target)
            {
                return res;
            }

            for (var i = 0; i < len - 3; i++)
            {
                if (n[i] + n[i + 1] + n[i + 2] + n[i + 3] > target)
                {
                    break;
                }
                var subSets = ThreeSum(n.Skip(i + 1).Take(len - i - 1).ToArray(), target - n[i]);
                if (subSets.Any())
                {
                    foreach (var set in subSets)
                    {
                        set.Add(n[i]);
                        res.Add(set);
                    }
                }
                while (i < len - 3 && n[i] == n[i + 1]) i++;
            }
            return res;
        }

        public List<IList<int>> ThreeSum(int[] n, int target)
        {
            var res = new List<IList<int>>();
            //var n = nums.OrderBy(num => num).ToList();
            for (var i = 0; i < n.Length - 2; i++)
            {
                var lo = i + 1;
                var hi = n.Length - 1;
                while (lo < hi)
                {
                    var sum = n[i] + n[lo] + n[hi];
                    if (sum == target)
                    {
                        res.Add(new List<int> { n[i], n[lo], n[hi]});
                        while (lo < hi && n[lo] == n[lo + 1]) lo++;
                        while (lo < hi && n[hi] == n[hi - 1]) hi--;
                        lo++;
                        hi--;
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
                }

                while (i < n.Length - 2 && n[i] == n[i + 1]) i++;
            }

            return res;
        }
    }
}
