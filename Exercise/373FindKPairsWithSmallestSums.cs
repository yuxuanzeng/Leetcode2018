using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    public class _373FindKPairsWithSmallestSums
    {
        public class Pair:IComparable
        {
            public int i1 { get; set; }
            public int i2 { get; set; }
            public int val1 { get; set; }
            public int val2 { get; set; }
            public int sum {
                get {
                    return this.val1 + this.val2;
                }
            }

            public Pair(int i1, int i2, int val1, int val2)
            {
                this.i1 = i1;
                this.i2 = i2;
                this.val1 = val1;
                this.val2 = val2;
            }

            public int CompareTo(object that)
            {
                if (this.sum != ((Pair)that).sum) {
                    return this.sum - ((Pair)that).sum;
                }
                if (this.i1 != ((Pair)that).i1) {
                    return this.i1 - ((Pair)that).i1;
                }
                return this.i2 - ((Pair)that).i2;
            }
        }
        public IList<int[]> KSmallestPairs(int[] nums1, int[] nums2, int k)
        {
            if (nums1 == null || nums2 == null || nums1.Length == 0 || nums2.Length == 0)
            {
                return new List<int[]>();
            }
            var list = new SortedSet<Pair>();
            for (var i = 0; i < nums1.Length; i++) {
                list.Add(new Pair(i, 0, nums1[i], nums2[0]));
            }
            var maxPairs = Math.Min(k, nums1.Length * nums2.Length);
            var res = new List<int []>();
            for (var j = 0; j < maxPairs - 1; j++) {
                var curPair = list.First();
                list.Remove(curPair);
                res.Add(new int[] { curPair.val1, curPair.val2});
                if (curPair.i2 == nums2.Length - 1) {
                    continue;
                }
                list.Add(new Pair(curPair.i1, curPair.i2 + 1, nums1[curPair.i1], nums2[curPair.i2 + 1]));
            }
            var pair = list.First();
            res.Add(new int[] { pair.val1, pair.val2 });
            return res;
        }
    }
}
