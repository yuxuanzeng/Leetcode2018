using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _54SpiralMatrix
    {
        public IList<int> SpiralOrder(int[,] matrix)
        {
            var ret = new List<int>();
            var row = matrix.GetLength(0);
            var col = matrix.GetLength(1);

            for (var i = 0; row - 1 - 2 * i >= 0 && col - 1 - 2 * i >= 0; i++)
            {
                ret.Add(matrix[i,i]);
                for (var r = i + 1; r <= col - 1 - i; r++)
                {
                    ret.Add(matrix[i,r]);
                }
                for (var d = i+1; d <= row - 1 - i; d++)
                {
                    ret.Add(matrix[d, col-1-i]);
                }
                if (i == col - 1 - i || i == row - 1 - i)
                {
                    continue;
                }
                for (var l = col - 2 - i; l >= i; l--)
                {
                    ret.Add(matrix[row-1-i, l]);
                }
                for (var u = row - 2 - i; u > i; u--)
                {
                    ret.Add(matrix[u,i]);
                }
            }
            return ret;
        }
    }
}
