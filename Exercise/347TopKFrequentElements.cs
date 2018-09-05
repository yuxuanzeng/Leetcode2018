using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _347TopKFrequentElements
    {
        public class Num : IComparable
        {
            public int val { get; set; }
            public int freq { get; set; }
            public Num(int val, int freq)
            {
                this.val = val;
                this.freq = freq;
            }
            public int CompareTo(object obj)
            {
                var that = (Num)obj;
                if (this.freq == that.freq)
                {
                    return this.val - that.val;
                }
                return that.freq - this.freq;
            }
        }

        public IList<int> TopKFrequent(int[] nums, int k)
        {
            var dicts = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (dicts.ContainsKey(num))
                {
                    dicts[num]++;
                }
                else {
                    dicts[num] = 1;
                }
            }

            var sorted = new SortedSet<Num>();
            foreach (var dict in dicts)
            {
                sorted.Add(new Num(dict.Key, dict.Value));
                if (sorted.Count > k)
                {
                    sorted.Remove(sorted.Last());
                }
            }
            return sorted.Select(s => s.val).ToList();
        }
    }
}
