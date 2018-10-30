using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _260StringNumberIII
    {
        public int[] SingleNumber(int[] nums)
        {
            var twoNums = 0;
            foreach (var num in nums)
            {
                twoNums ^= num;
            }

            var num1 = 0;
            var num2 = 0;
            var deltaBit = (twoNums & -twoNums);
            foreach (var num in nums)
            {
                if ((num & deltaBit) == 0)
                {
                    num1 ^= num;
                }
                else
                {
                    num2 ^= num;
                }
            }
            return new int[] { num1, num2};
        }
    }
}
