using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _864TransposeMatrix
    {
        public int[][] Transpose(int[][] A)
        {
            var rows = A.GetLength(1);

            var columns = A[0].Length;

            var newA = new int[rows][];

            for (var i = 0; i < rows; i++)
            {
                var newRow = new List<int>();
                for (var j = 0; j < columns; j++) {
                    newRow.Add(A[j][i]);
                }
                newA[i] = newRow.ToArray();
            }
            return newA;
        }
    }
}
