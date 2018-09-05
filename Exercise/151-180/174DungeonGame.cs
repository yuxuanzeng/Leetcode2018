using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _174DungeonGame
    {
        public int CalculateMinimumHP(int[][] dungeon)
        {
            if (dungeon == null)
            {
                return 0;
            }
            var row = dungeon.Count();
            var col = dungeon[0].Length;
            if (row == 0 || col == 0)
            {
                return 0;
            }

            var h = new int[row, col];
            h[row - 1, col - 1] = Math.Max(1 - dungeon[row - 1][col - 1], 1);

            for (var i = row - 2; i >= 0; i--)
            {
                h[i, col - 1] = Math.Max(h[i + 1, col - 1] - dungeon[i][col - 1], 1);
            }
            for (var i = col - 2; i >= 0; i--)
            {
                h[row - 1, i] = Math.Max(h[row-1, i+1] - dungeon[row-1][i], 1);
            }

            for (var i = row - 2; i >= 0; i--)
            {
                for (var j = col - 2; j >= 0; j--)
                {
                    var minH = Math.Min(h[i+1,j],h[i,j+1]);
                    h[i, j] = Math.Max(minH - dungeon[i][j],1);
                }
            }
            return h[0,0];
        }
    }
}
