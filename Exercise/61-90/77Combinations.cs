using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _77Combinations
    {
        public IList<IList<int>> Combine(int n, int k)
        {
            var nums = new int[n];
            for (var i = 0; i < n; i++)
            {
                nums[i] = i + 1;
            }
            var ret = new List<IList<int>>();
            backtrack(ret, new List<int>(), nums, 0, k);
            return ret;
        }

        private void backtrack(IList<IList<int>> ret, List<int> cur, int[] nums, int lo, int len)
        {
            if (cur.Count == len)
            {
                ret.Add(new List<int>(cur));
            }
            for (var i = lo; i < nums.Length; i++)
            {
                cur.Add(nums[i]);
                backtrack(ret, cur, nums, i+1, len);
                cur.RemoveAt(cur.Count - 1);
            }
        }
    }
}
