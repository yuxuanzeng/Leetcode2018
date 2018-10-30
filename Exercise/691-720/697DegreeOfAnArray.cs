using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _697DegreeOfAnArray_2
    {
        public class elem
        {
            public int freq { get; set; } = 0;
            public int startIndex { get; set; } = -1;
            public int endIndex { get; set; } = -1;
        }
        public int FindShortestSubArray(int[] nums)
        {
            
            if (nums == null || !nums.Any())
            {
                return 0;
            }
            var dict = new Dictionary<int, elem>();
            dict.Add(nums[0], new elem { freq = 1, startIndex = 0, endIndex = 0});
            var mostFreq = 1;
            var len = 1;
            for (var i = 1; i<nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]].freq++;
                    dict[nums[i]].endIndex = i;
                    if (dict[nums[i]].freq > mostFreq)
                    {
                        mostFreq = dict[nums[i]].freq;
                        len = dict[nums[i]].endIndex - dict[nums[i]].startIndex + 1;
                    }
                    else if (dict[nums[i]].freq == mostFreq)
                    {
                        if (dict[nums[i]].endIndex - dict[nums[i]].startIndex + 1 < len)
                        {
                            len = dict[nums[i]].endIndex - dict[nums[i]].startIndex + 1;
                        }
                    }
                }
                else
                {
                    dict.Add(nums[i], new elem { freq = 1, startIndex = i });
                }
            }
            return len;
        }
    }
}
