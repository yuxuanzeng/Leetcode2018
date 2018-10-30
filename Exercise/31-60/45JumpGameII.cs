using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _45JumpGameII
    {
        //public int Jump(int[] nums)
        //{
        //    if (nums == null || nums.Length <= 1)
        //    {
        //        return 0;
        //    }
        //    //var step = nums[0];
        //    var i = 0;
        //    var jump = 0;
        //    while (i < nums.Length - 1)
        //    {
        //        var step = nums[i];
        //        jump++;
        //        var max = nums[i + 1] + i + 1;
        //        var maxI = i + 1;
        //        for (var j = 2; j <= step; j++)
        //        {
        //            if (i + j >= nums.Length - 1)
        //            {
        //                return jump++;
        //            }
        //            if (nums[i + j] + i + j >= max)
        //            {
        //                max = nums[i + j] + i + j;
        //                maxI = i + j;
        //            }

        //        }
        //        i = maxI;
        //    }
        //    return jump;
        //}

        public int Jump(int[] nums)
        {
            int jumps = 0, curEnd = 0, curFarthest = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                curFarthest = Math.Max(curFarthest, i + nums[i]);
                if (i == curEnd)
                {
                    jumps++;
                    curEnd = curFarthest;
                }
            }
            return jumps;
        }
    }
}
