using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _697DegreeOfAnArray
    {
        public class Item {
            public int degree { get; set; }
            public int startIndex { get; set; }
            public int endIndex { get; set; }
        }
        public int FindShortestSubArray(int[] nums)
        {
            var dict = new Dictionary<int, Item>();
            if (nums.Length == 0) {
                return 0;
            }
            if (nums.Length == 1) {
                return 1;
            }

            for (var i = 0; i < nums.Length; i++) {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]].degree++;
                    dict[nums[i]].endIndex = i;
                }
                else {
                    dict.Add(nums[i], new Item() { degree = 1, startIndex = i, endIndex = i});
                }
            }

            var items = dict.Values.OrderByDescending(v => v.degree).ToList();

            var subLen = items[0].endIndex - items[0].startIndex + 1;
            for (var j = 1; j < items.Count() - 1 && items[j].degree == items[0].degree; j++)
            {
                subLen = Math.Min(subLen, items[j].endIndex - items[j].startIndex + 1);
            }
            return subLen;
        }
    }
}
