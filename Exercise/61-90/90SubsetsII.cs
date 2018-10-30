using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _90SubsetsII
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            nums = nums.OrderBy(n => n).ToArray();
            var ret = new List<IList<int>>() { new List<int>() { } };
            var lastSubsets = new List<IList<int>>();
            var lastNum = 0;
            if (nums.Length >= 1)
            {
                lastSubsets.Add(new List<int> { nums[0]});
                ret.Add(new List<int> { nums[0] });
                lastNum = nums[0];
            }
            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i] != lastNum)
                {
                    lastSubsets.Clear();
                    foreach (var subset in ret)
                    {
                        var temp = new int[subset.Count()];
                        subset.CopyTo(temp, 0);
                        var newSubset = temp.ToList();
                        newSubset.Add(nums[i]);
                        lastSubsets.Add(newSubset);
                    }
                    lastNum = nums[i];
                    ret.AddRange(lastSubsets);
                }
                else
                {
                    var newSubsets = new List<IList<int>>();
                    foreach (var lastSubset in lastSubsets)
                    {
                        var temp = new int[lastSubset.Count()];
                        lastSubset.CopyTo(temp, 0);
                        var newSubset = temp.ToList();
                        newSubset.Add(nums[i]);
                        lastSubset.Add(nums[i]);
                        newSubsets.Add(newSubset);
                    }
                    ret.AddRange(newSubsets);
                }
            }
            return ret;
        }
    }
}
