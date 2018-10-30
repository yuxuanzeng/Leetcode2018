using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _216CombinationSumIII
    {
        public IList<IList<int>> CombinationSum3(int k, int n)
        {
            var nums = new int[] { 1,2,3,4,5,6,7,8,9};
            var ret = new List<IList<int>>();
            backtrack(ret, new List<int>(), nums, 0, n, k);
            return ret;
        }

        private void backtrack(IList<IList<int>> ret, List<int> cur, int[] nums, int lo, int target, int maxLen)
        {
            if (cur.Count() >= maxLen)
            {
                return;
            }
            for (var i = lo; i < 9; i++)
            {

                cur.Add(nums[i]);
                if (cur.Sum() > target)
                {
                    cur.RemoveAt(cur.Count() - 1);
                    break;
                }
                if (cur.Sum() == target)
                {
                    if (cur.Count == maxLen)
                    {
                        ret.Add(new List<int>(cur));
                    }
                    cur.RemoveAt(cur.Count() - 1);
                    break;
                }
                backtrack(ret, cur, nums, i+1, target, maxLen);
                cur.RemoveAt(cur.Count() - 1);
            }
        }
    }
}
