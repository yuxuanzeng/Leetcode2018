using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _60PermutationSequence
    {
        public string GetPermutation(int n, int k)
        {
            var nums = new int[n];
            for (var i = 0; i < n; i++)
            {
                nums[i] = i + 1;
            }
            var ret = new List<char>();
            for (var i = 0; i < n; i++)
            {
                var j = 0;
                var step = getFactorial(n-i-1);
                while ((j + 1) * step < k)
                {
                    j++;
                }
                k -= j * step;
                var m = 0;
                while (nums[m] > 9 || m < j)
                {
                    if (nums[m] > 9)
                    {
                        m++;
                        j++;
                    }
                    else
                    {
                        m++;
                    }
                }
                ret.Add(nums[m].ToString()[0]);
                nums[m] += 9;
                
            }
            return string.Concat(ret);
        }

        private int getFactorial(int i)
        {
            if (i <= 1)
            {
                return 1;
            }
            return i * getFactorial(i-1);
        }
    }
}
