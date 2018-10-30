using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _64MinimumPathSum
    {
        public int MinPathSum(int[,] grid)
        {
            var row = grid.GetLength(0);
            var col = grid.GetLength(1);
            var ret = new int[row, col];

            ret[0, 0] = grid[0, 0];
            for (var i = 1; i < row; i++)
            {
                ret[i, 0] = ret[i - 1,0] + grid[i,0];
            }
            for (var j = 1; j < col; j++)
            {
                ret[0, j] = ret[0, j - 1] + grid[0,j];
            }
            for (var i = 1; i < row; i++)
            {
                for (var j = 1; j < col; j++)
                {
                    ret[i, j] = Math.Min(ret[i - 1, j], ret[i, j - 1]) + grid[i, j];
                }
            }
            return ret[row - 1, col - 1];
        }
    }
}
