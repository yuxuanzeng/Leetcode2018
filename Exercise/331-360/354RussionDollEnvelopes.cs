using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Envelope : IComparable
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public Envelope(int len, int wid)
        {
            Length = len;
            Width = wid;
        }

        public int CompareTo(object obj)
        {
            var that = (Envelope)obj;
            if (this.Length == that.Length)
            {
                return that.Width - this.Width;
            }
            return this.Length - that.Length;
        }
    }
    public class _354RussionDollEnvelopes
    {
        public int MaxEnvelopes(int[,] envelopes)
        {
            var envCount = envelopes.GetLength(0);
            var sorted = new SortedSet<Envelope>();
            for (var i = 0; i < envCount; i++)
            {
                sorted.Add(new Envelope(envelopes[i, 0], envelopes[i, 1]));
            }
            var widths = sorted.Select(s => s.Width).ToArray();
            return SearchLongestSubsequence(widths);
        }

        private int SearchLongestSubsequence(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            var size = 1;
            var res = new int[nums.Length];
            res[0] = nums[0];
            for (var i = 0; i < nums.Length; i++)
            {
                var pos = BinarySearch(res, size, nums[i]);
                res[pos] = nums[i];
                if (pos + 1 > size)
                {
                    size++;
                }
            }
            return size;
        }

        private int BinarySearch(int[] res, int len, int target)
        {
            var lo = 0;
            var hi = len - 1;
            while (lo < hi)
            {
                var mid = lo + (hi - lo) / 2;
                if (res[mid] == target)
                {
                    return mid;
                }
                else if (res[mid] > target)
                {
                    hi = mid;
                }
                else
                {
                    lo = mid + 1;
                }
            }
            if (res[lo] >= target)
            {
                return lo;
            }
            return lo + 1;
        }
    }
}
