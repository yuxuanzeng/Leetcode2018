using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _39CombinationSum
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            var ret = new List<IList<int>>();
            Array.Sort(candidates);
            backtrack(ret, new List<int>(), candidates, target, 0);
            return ret;
        }

        private void backtrack(IList<IList<int>> ret, List<int> cur, int[] nums, int target, int lo)
        {
            for (var i = lo; i < nums.Length; i++)
            {
                cur.Add(nums[i]);
                if (cur.Sum() > target)
                {
                    cur.RemoveAt(cur.Count()- 1);
                    break;
                }
                if (cur.Sum() == target)
                {
                    ret.Add(new List<int> (cur));
                    cur.RemoveAt(cur.Count() - 1);
                    break;
                }
                backtrack(ret, cur, nums, target, i);
                cur.RemoveAt(cur.Count() - 1);
            }
        }
    }
}
