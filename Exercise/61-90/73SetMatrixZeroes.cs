using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _73SetMatrixZeroes
    {
        public void SetZeroes(int[,] matrix)
        {
            var row = matrix.GetLength(0);
            var col = matrix.GetLength(1);

            var rowZeroes = false;
            for (var j = 0; j < col; j++)
            {
                if (matrix[0, j] == 0)
                {
                    rowZeroes = true;
                    break;
                }
            }
            var colZeroes = false;
            for (var i = 0; i < row; i++)
            {
                if (matrix[i, 0] == 0)
                {
                    colZeroes = true;
                    break;
                }
            }

            for (var i = 1; i < row; i++)
            {
                for (var j = 0; j < col; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        matrix[i, 0] = 0;
                    }
                }
            }

            for (var j = 1; j < col; j++)
            {
                for (var i = 0; i < row; i++)
                {
                    if (matrix[i, j] == 0)
                    {
                        matrix[0, j] = 0;
                    }
                }
            }

            for (var i = 1; i < row; i++)
            {
                for (var j = 1; j < col; j++)
                {
                    if (matrix[0, j] == 0 || matrix[i,0] == 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            if (rowZeroes)
            {
                for (var j = 0; j < col; j++)
                {
                    matrix[0, j] = 0;
                }
            }

            if (colZeroes)
            {
                for (var i = 0; i < row; i++)
                {
                    matrix[i, 0] = 0;
                }
            }
        }
    }
}
