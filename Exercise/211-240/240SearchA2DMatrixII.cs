using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _240SearchA2DMatrixII
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            if (matrix == null)
            {
                return false;
            }
            var row = matrix.GetLength(0);
            var col = matrix.GetLength(1);
            if (row == 0 || col == 0)
            {
                return false;
            }

            var trr = 0;
            var trc = col - 1;
            while (trr <= row - 1 && trc >= 0)
            {
                if (target < matrix[trr, trc])
                {
                    trc--;
                }
                else if (target > matrix[trr, trc])
                {
                    trr++;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
