using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _46Permutations
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var ret = new List<IList<int>>();
            var used = new bool[nums.Count()];
            backtrack(ret, new List<int>(), used, nums);
            return ret;
        }

        private void backtrack(IList<IList<int>> ret, List<int> cur, bool[] used, int[] nums)
        {
            if (cur.Count == nums.Length)
            {
                ret.Add(new List<int>(cur));
                return;
            }
            for (var i = 0; i < nums.Length; i++)
            {
                if (used[i]) {
                    continue;
                }
                cur.Add(nums[i]);
                used[i] = true;
                backtrack(ret, cur, used, nums);
                used[i] = false;
                cur.RemoveAt(cur.Count - 1);
            }
        }
    }
}
