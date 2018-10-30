using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _137SingleNumberII
    {
        public int SingleNumber(int[] nums)
        {
            var ones = 0;
            var twos = 0;
            foreach (var num in nums)
            {
                ones = (ones ^ num) & ~twos;
                twos = (twos ^ num) & ~ones;
            }
            return ones;
        }
    }
}
