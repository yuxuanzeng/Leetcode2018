using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _363MaxSumOfRectangleNoLargerThanK
    {
        public int MaxSumSubmatrix(int[,] matrix, int k)
        {
            if (matrix == null)
            {
                return 0;
            }
            var res = Int32.MinValue;
            var rowNum = matrix.GetLength(0);
            var colNum = matrix.GetLength(1);
            if (rowNum == 0 || colNum == 0)
            {
                return 0;
            }
            var row = Math.Max(rowNum, colNum);
            var col = Math.Min(rowNum, colNum);
            var colIsLarge = colNum > rowNum;
            var curSum = new int[row];

            for (var l = 0; l < col; l++)
            {
                for (var i = 0; i < row; i++)
                {
                    curSum[i] = 0;
                }
                for (var r = l; r < col; r++)
                {
                    var rowSums = new SortedSet<int>();
                    rowSums.Add(0);
                    //var rowSums = new List<int>();
                    var rowSum = 0;
                    for (var j = 0; j < row; j++) {
                        curSum[j] += colIsLarge ? matrix[r, j] : matrix[j, r];
                        rowSum += curSum[j];
                        var target = rowSum - k;
                        var pos = BinarySearchLowerBound(rowSums.ToArray(), target);
                        if (pos < rowSums.Count)
                        {
                            res = Math.Max(res, rowSum - rowSums.ElementAt(pos));
                            if (res == k)
                            {
                                return res;
                            }
                        }
                        //rowSums.Add(rowSum);
                        //for (var m = -1; m < j; m++)
                        //{
                        //    int liValue = rowSums[j] - (m == 0 ? 0 : rowSums[m]);
                        //    if (liValue == k)
                        //        return k;
                        //    if (liValue <= k)
                        //        res = Math.Max(res, liValue);
                        //}
                    }
                    //var maxSum = MaxSumNoMoreThanK(curSum, k);
                    //res = Math.Max(maxSum, res);
                }
            }

            return res;
        }

        //private int MaxSumNoMoreThanK(int[] nums, int k)
        //{
        //    var maxSum = Int32.MinValue;
        //    var curSum = 0;
        //    var sums = new SortedSet<int>();
        //    sums.Add(0);
        //    //var r = 0;
        //    for (var r = 0; r < nums.Length; r++)
        //    {
        //        curSum += nums[r];
        //        var target = curSum - k;
        //        var pos = BinarySearchLowerBound(sums.ToArray(), target);
        //        if (pos < sums.Count)
        //        {
        //            maxSum = Math.Max(maxSum, curSum - sums.ElementAt(pos));
        //        }
        //        sums.Add(curSum);
        //    }
        //    return maxSum;
        //}

        // The minimum value larger or equal than t.
        private int BinarySearchLowerBound(int[] nums, int t)
        {
            var lo = 0;
            var hi = nums.Length - 1;
            while (lo < hi)
            {
                var mid = lo + (hi - lo) / 2;
                if (nums[mid] == t)
                {
                    return mid;
                }
                else if (nums[mid] < t)
                {
                    lo = mid + 1;
                }
                else
                {
                    hi = mid;
                }
            }
            return nums[lo] < t ? lo + 1 : lo;
        }
    }
}
