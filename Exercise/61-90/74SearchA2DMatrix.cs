using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _74SearchA2DMatrix
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            if (matrix == null)
            {
                return false;
            }

            var colNum = matrix.GetLength(1);
            var rowNum = matrix.GetLength(0);
            if (colNum == 0 || rowNum == 0)
            {
                return false;
            }
            var selectedRow = 0;
            if (rowNum > 1)
            {
                var lastNums = new List<int>();
                for (var i = 0; i < rowNum; i++)
                {
                    lastNums.Add(matrix[i, colNum - 1]);
                }
                selectedRow = FindInsertIndex(lastNums.ToArray(), target);
            }
            if (selectedRow > rowNum)
            {
                return false;
            }
            var selectedColNums = new List<int>();
            for (var j = 0; j < colNum; j++)
            {
                selectedColNums.Add(matrix[selectedRow, j]);
            }
            return SearchNum(selectedColNums.ToArray(), target);
        }

        private int FindInsertIndex(int[] nums, int target)
        {
            var lo = 0;
            var hi = nums.Length - 1;
            var index = 0;
            if (target > nums[hi])
            {
                return hi + 1;
            }
            while (lo < hi)
            {
                var mid = lo + (hi - lo) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    //index = mid;
                    lo = mid + 1;
                    index = mid + 1;
                }
                else
                {
                    hi = mid;
                    index = hi;
                }
            }
            return index;
        }

        private bool SearchNum(int[] nums, int target)
        {
            var lo = 0;
            var hi = nums.Length - 1;
            while (lo < hi)
            {
                var mid = lo + (hi - lo) / 2;
                if (nums[mid] == target)
                {
                    return true;
                }
                else if (nums[mid] < target)
                {
                    lo = mid + 1;
                }
                else
                {
                    hi = mid;
                }
            }
            return nums[lo] == target;
        }
    }
}
