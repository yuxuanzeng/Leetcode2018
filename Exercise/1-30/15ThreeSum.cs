using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _15ThreeSum
    {
        //public IList<IList<int>> ThreeSum(int[] nums)
        //{
        //    var res = new List<IList<int>>();
        //    if (nums == null || nums.Length < 3)
        //    {
        //        return res;
        //    }

        //    var len = nums.Length;
        //    var sorted = nums.OrderBy(n => n).ToList();
        //    if (sorted[0] > 0 || sorted[len - 1] < 0)
        //    {
        //        return res;
        //    }
        //    var nIndex = 0;
        //    var preNum = sorted[len - 1] + 1;
        //    while (nIndex < len && sorted[nIndex] < 0)
        //    {
        //        if (sorted[nIndex] == preNum)
        //        {
        //            nIndex++;
        //            continue;
        //        }
        //        var preP = -1;
        //        for (var i = len - 1; i > nIndex && sorted[i] > 0; i--)
        //        {
        //            if (sorted[i] == preP)
        //            {
        //                continue;
        //            }
        //            if (sorted.Skip(nIndex + 1).Take(i - nIndex - 1).Contains(-(sorted[nIndex] + sorted[i])))
        //            {
        //                res.Add(new List<int>() { sorted[nIndex], sorted[i], -sorted[nIndex] - sorted[i] });
        //            }
        //            preP = sorted[i];
        //        }
        //        preNum = sorted[nIndex];
        //        nIndex++;
        //    }

        //    if (sorted.Where(c => c == 0).Count() >= 3)
        //    {
        //        res.Add(new List<int>() { 0,0,0});
        //    }
        //    return res;
        //}
        //public class Set
        //{
        //    public Set(int n1, int n2)
        //    {
        //        this.n1 = n1;
        //        this.n2 = n2;
        //        this.target = -(n1 + n2);
        //    }
        //    public int n1 { get; set; }
        //    public int n2 { get; set; }

        //    public int target { get; set; }
        //}

        //public IList<IList<int>> ThreeSum(int[] nums)
        //{
        //    var res = new List<IList<int>>();
        //    if (nums == null || nums.Length < 3)
        //    {
        //        return res;
        //    }

        //    var len = nums.Length;
        //    var sorted = nums.OrderBy(n => n);
        //    var sortedNums = sorted.ToList();
        //    if (sortedNums[0] > 0 || sortedNums[len - 1] < 0)
        //    {
        //        return res;
        //    }
        //    var nIndex = 0;
        //    var pIndex = len - 1;
        //    var preNum = 1;

        //    var possibleSets = new List<Set>();
        //    while (nIndex < pIndex - 1)
        //    {
        //        if (sortedNums[nIndex] == preNum)
        //        {
        //            nIndex++;
        //            continue;
        //        }

        //        var preP = -1;
        //        for (var i = pIndex; i > nIndex + 1; i--)
        //        {
        //            if (sortedNums[i] == preP)
        //            {
        //                //pIndex--;
        //                //pIndex = i;
        //                continue;
        //            }
        //            if (sortedNums[nIndex] + sortedNums[i] + sortedNums[nIndex + 1] > 0)
        //            {
        //                preP = sortedNums[i];
        //                pIndex --;
        //                continue;
        //            }
        //            if (sortedNums[nIndex] + sortedNums[i] + sortedNums[i - 1] < 0)
        //            {
        //                break;
        //            }

        //            possibleSets.Add(new Set(sortedNums[nIndex], sortedNums[i]));
        //            preP = sortedNums[i];
        //        }
        //        preNum = sortedNums[nIndex];
        //        nIndex++;
        //    }

        //    var orderedSets = possibleSets.OrderBy(p => p.target).ToList();
        //    var setIndex = 0;
        //    for (var i = 0; i < sortedNums.Count() && setIndex < possibleSets.Count(); i++)
        //    {
        //        while (setIndex < possibleSets.Count() && orderedSets[setIndex].target < sortedNums[i])
        //        {
        //            setIndex++;
        //        }

        //        //if (setIndex < possibleSets.Count() && orderedSets[setIndex].target == sortedNums[i])
        //        //{
        //        //    res.Add(new List<int>() { orderedSets[setIndex].n1, orderedSets[setIndex].n2, orderedSets[setIndex].target });
        //        //    setIndex++;
        //            while (setIndex < possibleSets.Count() && orderedSets[setIndex].target == sortedNums[i])
        //            {
        //                res.Add(new List<int>() { orderedSets[setIndex].n1, orderedSets[setIndex].n2, orderedSets[setIndex].target });
        //                setIndex++;
        //            }
        //         //   continue;
        //        //}
        //    }

        //    //if (sorted.Where(c => c == 0).Count() >= 3)
        //    //{
        //    //    res.Add(new List<int>() { 0, 0, 0 });
        //    //}
        //    return res;


        //}

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var res = new List<IList<int>>();
            var n = nums.OrderBy(num => num).ToList();
            for (var i = 0; i < n.Count - 2; i++)
            {
                if (i == 0 || (i > 0 && n[i] != n[i - 1]))
                {
                    var lo = i + 1;
                    var hi = n.Count - 1;
                    var sum = 0 - n[i];
                    while (lo < hi)
                    {
                        //var curSum = n[lo] + n[hi];

                        if (n[lo] + n[hi] == sum)
                        {
                            res.Add(new List<int>() { n[i], n[lo], n[hi] });
                            while (lo < hi && n[lo] == n[lo + 1]) lo++;
                            while (lo < hi && n[hi] == n[hi - 1]) hi--;
                            lo++;
                            hi--;
                        }
                        else if (n[lo] + n[hi] < sum)
                        {
                            //while (lo < hi && n[lo] == n[lo + 1]) lo++;
                            //while (lo < hi && n[hi] == n[hi - 1]) hi--;
                            lo++;
                        }
                        else
                        {
                            //while (lo < hi && n[lo] == n[lo + 1]) lo++;
                            //while (lo < hi && n[hi] == n[hi - 1]) hi--;
                            hi--;
                        }
                    }
                }
            }

            return res;
        }
    }
}
