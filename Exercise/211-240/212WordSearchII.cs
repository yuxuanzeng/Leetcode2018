using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _212WordSearchII
    {
        public IList<string> FindWords(char[,] board, string[] words)
        {
            var ret = new List<string>();
            var uniqueWords = words.Distinct();
            foreach (var word in uniqueWords)
            {
                if (exists(board, word))
                {
                    ret.Add(word);
                }
            }
            return ret;
        }

        private bool exists(char[,] board, string word)
        {
            var row = board.GetLength(0);
            var col = board.GetLength(1);
            var used = new bool[row, col];
            for (var i = 0; i < row; i++)
            {
                for (var j = 0; j < col; j++)
                {
                    if (backtrack(board, used, word, 0, i, j))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool backtrack(char[,] board, bool[,] used, string word, int pos, int row, int col)
        {
            if (board[row, col] != word[pos])
            {
                return false;
            }
            if (pos == word.Length - 1)
            {
                return true;
            }
            used[row, col] = true;
            var ret = false;
            if (row - 1 >= 0 && !used[row - 1, col])
            {
                ret = backtrack(board, used, word, pos + 1, row - 1, col);
            }
            if (ret)
            {
                return true;
            }
            if (row + 1 <= board.GetLength(0) - 1 && !used[row + 1, col])
            {
                ret = backtrack(board, used, word, pos + 1, row + 1, col);
            }
            if (ret)
            {
                return true;
            }
            if (col - 1 >= 0 && !used[row, col - 1])
            {
                ret = backtrack(board, used, word, pos + 1, row, col - 1);
            }
            if (ret)
            {
                return true;
            }
            if (col + 1 <= board.GetLength(1) - 1 && !used[row, col + 1])
            {
                ret = backtrack(board, used, word, pos + 1, row, col + 1);
            }
            if (ret)
            {
                return true;
            }
            used[row, col] = false;
            return false;
        }
    }
}
