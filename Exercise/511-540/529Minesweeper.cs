using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _529Minesweeper
    {
        public char[,] UpdateBoard(char[,] board, int[] click)
        {
            var clickedRow = click[0];
            var clickedCol = click[1];
            var clicked = board[clickedRow, clickedCol];
            var row = board.GetLength(0);
            var col = board.GetLength(1);
            if (clicked != 'E' || clicked != 'M')
            {
                return board;
            }
            if (clicked == 'M')
            {
                board[clickedRow, clickedCol] = 'X';
                return board;
            }
            var neighbors = new Queue<int[]>();
            neighbors.Enqueue(click);
            while (neighbors.Any())
            {
                var count = neighbors.Count();
                for (var i = 0; i < count; i++)
                {
                    var curNode = neighbors.Dequeue();
                    var digit = 0;
                    //Up
                    if (curNode[0] > 0)
                    {
                        if (board[curNode[0] - 1, curNode[1]] == 'E')
                        {
                            neighbors.Enqueue(new int[] { curNode[0] - 1, curNode[1] });
                        }
                        else if (board[curNode[0] - 1, curNode[1]] == 'M')
                        {
                            ++digit;
                        }

                        //Up Right
                        if (curNode[1] + 1 < col)
                        {
                            var upRight = board[curNode[0] - 1, curNode[1] + 1];
                            if (upRight == 'E')
                            {
                                neighbors.Enqueue(new int[] { curNode[0] - 1, curNode[1] + 1 });
                            }
                            else if (upRight == 'M')
                            {
                                ++digit;
                            }
                        }

                        //Up Left
                        if (curNode[1] > 0)
                        {
                            var upLeft = board[curNode[0] - 1, curNode[1] - 1];
                            if (upLeft == 'E')
                            {
                                neighbors.Enqueue(new int[] { curNode[0] - 1, curNode[1] - 1 });
                            }
                            else if (upLeft == 'M')
                            {
                                ++digit;
                            }
                        }
                    }

                    //Right
                    if (curNode[1] + 1 < col)
                    {
                        var right = board[curNode[0], curNode[1] + 1];
                        if (right == 'E')
                        {
                            neighbors.Enqueue(new int[] { curNode[0], curNode[1] + 1 });
                        }
                        else if (right == 'M')
                        {
                            ++digit;
                        }
                    }
                    //Left
                    if (curNode[1] > 0)
                    {
                        var left = board[curNode[0], curNode[1] - 1];
                        if (left == 'E')
                        {
                            neighbors.Enqueue(new int[] { curNode[0], curNode[1] - 1 });
                        }
                        else if (left == 'M')
                        {
                            ++digit;
                        }
                    }

                    //Down Right
                    //Down
                    //Down Left
                    if (curNode[0] + 1 < row)
                    {
                        var down = board[curNode[0] + 1, curNode[1]];
                        if (down == 'E')
                        {
                            neighbors.Enqueue(new int[] { curNode[0] + 1, curNode[1]});
                        }
                        else if (down == 'M')
                        {
                            ++digit;
                        }

                        if (curNode[1] + 1 < col)
                        {
                            var downRight = board[curNode[0] + 1, curNode[1] + 1];
                            if (downRight == 'E')
                            {
                                neighbors.Enqueue(new int[] { curNode[0] + 1, curNode[1] + 1 });
                            }
                            else if (downRight == 'M')
                            {
                                ++digit;
                            }
                        }

                        if (curNode[1] > 0)
                        {
                            var downLeft = board[curNode[0] + 1, curNode[1] - 1];
                            if (downLeft == 'E')
                            {
                                neighbors.Enqueue(new int[] { curNode[0] + 1, curNode[1] - 1 });
                            }
                            else if (downLeft == 'M')
                            {
                                ++digit;
                            }
                        }
                    }

                    if (digit == 0)
                    {
                        board[curNode[0], curNode[1]] = 'B';
                    }
                    else
                    {
                        board[curNode[0], curNode[1]] = (char)('0' + digit);
                    }

                }
            }
            return board;
        }
    }
}
