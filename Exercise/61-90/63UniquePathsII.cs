using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _63UniquePathsII
    {
        public int UniquePathsWithObstacles(int[,] obstacleGrid)
        {
            var row = obstacleGrid.GetLength(0);
            var col = obstacleGrid.GetLength(1);
            var ret = new int[row, col];
            if (obstacleGrid[0, 0] == 1)
            {
                ret[0, 0] = 0;
            }
            else
            {
                ret[0, 0] = 1;
            }
            for (var i = 1; i < row; i++)
            {
                if (obstacleGrid[i, 0] == 1)
                {
                    ret[i, 0] = 0;
                }
                else
                {
                    ret[i, 0] = ret[i - 1, 0];
                }
            }
            for (var j = 1; j < col; j++)
            {
                if (obstacleGrid[0, j] == 1)
                {
                    ret[0, j] = 0;
                }
                else
                {
                    ret[0, j] = ret[0, j - 1];
                }
            }
            for (var i = 1; i < row; i++)
            {
                for (var j = 1; j < col; j++)
                {
                    if (obstacleGrid[i, j] == 1)
                    {
                        ret[i, j] = 0;
                    }
                    else if (i == 0)

                    {
                        ret[i, j] = ret[i, j - 1];
                    }
                    else if (j == 0)
                    {
                        ret[i, j] = ret[i-1,j];
                    }
                    else
                    {
                        ret[i, j] = ret[i - 1, j] + ret[i, j - 1];
                    }
                }
            }
            return ret[row-1,col-1];
        }
    }
}
