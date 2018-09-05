using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _36ValidSudoku
    {
        public bool IsValidSudoku(char[,] board)
        {
            var isValid = false;
            // Verify each row
            for (var i = 0; i < 9; i++)
            {
                var row = new List<char>();
                for (var j = 0; j < 9; j++)
                {
                    row.Add(board[i, j]);
                }
                isValid = IsValidSudokuSection(row.ToArray());
                if (!isValid)
                {
                    return false;
                }
            }
            // Verify each column
            for (var i = 0; i < 9; i++)
            {
                var column = new List<char>();
                for (var j = 0; j < 9; j++)
                {
                    column.Add(board[j, i]);
                }
                isValid = IsValidSudokuSection(column.ToArray());
                if (!isValid)
                {
                    return false;
                }
            }
            // Verify each block
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    var block = new List<char>();
                    block.Add(board[i, j]);
                    block.Add(board[i, j + 1]);
                    block.Add(board[i, j + 2]);
                    block.Add(board[i+1, j]);
                    block.Add(board[i+1, j + 1]);
                    block.Add(board[i+1, j + 2]);
                    block.Add(board[i+2, j]);
                    block.Add(board[i+2, j + 1]);
                    block.Add(board[i+2, j + 2]);
                    isValid = IsValidSudokuSection(block.ToArray());
                    if (!isValid)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool IsValidSudokuSection(char[] sec)
        {
            var nums = sec.Where(c => c != '.');
            return nums.Count() == nums.Distinct().Count();
        }
    }
}
