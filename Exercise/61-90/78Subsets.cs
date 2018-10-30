using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercis
{
    public class _78Subsets
    {
        //public IList<IList<int>> Subsets(int[] nums)
        //{
        //    var ret = new List<IList<int>> { new List<int> { } };
        //    foreach (var num in nums)
        //    {
        //        var newSubsets = new List<IList<int>>();
        //        foreach (var subset in ret)
        //        {
        //            var temp = new int[subset.Count];
        //            subset.CopyTo(temp,0);
        //            var newSubset = temp.ToList();
        //            newSubset.Add(num);
        //            newSubsets.Add(newSubset);
        //        }
        //        ret.AddRange(newSubsets);
        //    }
        //    return ret;
        //}

        public IList<IList<int>> Subsets(int[] nums)
        {
            var list = new List<IList<int>>();
            Array.Sort(nums);
            backtrack(list, new List<int>(), nums, 0);
            return list;
        }

        private void backtrack(IList<IList<int>> list, List<int> tempList, int[] nums, int start)
        {
            list.Add(new List<int>(tempList));
            for (int i = start; i < nums.Length; i++)
            {
                tempList.Add(nums[i]);
                backtrack(list, tempList, nums, i + 1);
                tempList.RemoveAt(tempList.Count - 1);
            }
        }
    }
}
