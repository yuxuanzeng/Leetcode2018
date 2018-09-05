using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _11ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            var water = 0;
            var i = 0;
            var j = height.Length - 1;
            while (i < j)
            {
                water = Math.Max(water, (j - i) * Math.Min(height[i], height[j]));
                if (height[i] < height[j])
                {
                    i++;
                }
                else {
                    j--;
                }
            }
            return water;
        }
    }
}
