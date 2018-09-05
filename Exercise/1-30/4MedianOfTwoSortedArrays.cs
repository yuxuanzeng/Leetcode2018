using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _4MedianOfTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var k1 = nums1.Length + nums2.Length + 1 >> 1;
            var k2 = nums1.Length + nums2.Length + 2 >> 1;
            if (k1 == k2)
            {
                return (double)getKthNum(nums1, nums1.Length, nums2, nums2.Length, k1);
            }
            return (getKthNum(nums1, nums1.Length, nums2, nums2.Length, k1) + getKthNum(nums1, nums1.Length, nums2, nums2.Length, k2)) / 2.0;
        }

        public int getKthNum(int[] n, int i, int[] m, int j, int k)
        {
            if (i > j)
            {
                return getKthNum(m, j, n, i, k);
            }
            if (i == 0)
            {
                return m[k - 1];
            }
            if (k == 1)
            {
                return Math.Min(n[0], m[0]);
            }

            int i2 = Math.Min(i, k / 2);
            int j2 = Math.Min(j, k / 2);
            if (n[i2 - 1] > m[j2 - 1])
            {
                return getKthNum(n, i, m.Skip(j2).Take(j - j2).ToArray(), j - j2, k - j2);
            }
            else
            {
                return getKthNum(n.Skip(i2).Take(i - i2).ToArray(), i - i2, m, j, k - i2);
            }
        }
    }
}
