using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _52NQueensII
    {
        public int TotalNQueens(int n)
        {
            var ret = new List<bool>();
            for (var i = 0; i < n; i++)
            {
                var board = new bool[n, n];
                IsSolution(ret, board, n, 0, i);
            }
            return ret.Count;
        }

        private void IsSolution(List<bool> ret, bool[,] board, int n, int row, int col)
        {
            // Queen can attack horizonally. Ignore. Not visiting same row anymore.
            // Queen can attack vertically.
            for (var m = 0; m < row; m++)
            {
                if (board[m, col])
                {
                    return;
                }
            }
            var i = row - 1;
            var j = col - 1;
            while (i >= 0 && j >= 0)
            {
                if (board[i, j])
                {
                    return;
                }
                i--;
                j--;
            }
            i = row - 1;
            j = col + 1;
            while (i >= 0 && j < n)
            {
                if (board[i, j])
                {
                    return;
                }
                i--;
                j++;
            }
            if (row == n - 1)
            {
                ret.Add(true);
                return;
            }
            board[row, col] = true;
            for (var k = 0; k < n; k++)
            {
                IsSolution(ret, board, n, row + 1, k);
             
            }
            board[row, col] = false;
        }
    }
}
