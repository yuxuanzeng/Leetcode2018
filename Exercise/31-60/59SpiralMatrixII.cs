using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _59SpiralMatrixII
    {
        public int[,] GenerateMatrix(int n)
        {
            var ret = new int[n, n];
            var count = 1;
            for (var i = 0; n - 1 - 2*i >= 0; i++)
            {
                ret[i, i] = count++;
                for (var r = i + 1; r < n - i; r++)
                {
                    ret[i, r] = count++;
                }
                for (var d = i + 1; d < n - i; d++)
                {
                    ret[d, n - i - 1] = count++;
                }
                for (var l = n - i - 2; l >= i; l--)
                {
                    ret[n - i - 1, l] = count++;
                }
                for (var u = n - i - 2; u > i; u--)
                {
                    ret[u, i] = count++;
                }
            }
            return ret;
        }

    }
}
