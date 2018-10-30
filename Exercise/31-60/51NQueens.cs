using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _51NQueens
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            var ret = new List<IList<string>>();

            for (var i = 0; i < n; ++i)
            {
                var board = new bool[n,n];
                backtrack(ret, board, n, 0,i);
            }
            return ret;
        }

        private void backtrack(IList<IList<string>> ret, bool[,] board, int n, int row, int col)
        {
            for (var m = 0; m < row; ++m)
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
                --i;
                --j;
            }
            i = row - 1;
            j = col + 1;
            while (i >= 0 && j < n)
            {
                if (board[i, j])
                {
                    return;
                }
                --i;
                ++j;
            }
            if (row == n - 1)
            {
                board[row, col] = true;
                getBoardStr(ret, board, n);
                board[row, col] = false;
                return;
            }
            board[row, col] = true;
            for (var k = 0; k < n; k++)
            {
                backtrack(ret, board, n, row + 1, k);
            }
            board[row, col] = false;
        }

        private void getBoardStr(IList<IList<string>> ret, bool[,] board, int n)
        {
            var strList = new List<string>();
            for (var i = 0; i < n; i++)
            {
                var str = string.Empty;
                for (var j = 0; j < n; j++)
                {
                    if (board[i, j])
                    {
                        str += "Q";
                    }
                    else
                    {
                        str += ".";
                    }
                }
                strList.Add(str);
            }

            ret.Add(new List<string>(strList));
        }
    }
}
