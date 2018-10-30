using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _62UniquePaths
    {
        public int UniquePaths(int m, int n)
        {
            var ret = new int[m,n];
            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        ret[i, j] = 1;
                    }
                    else
                    {
                        ret[i, j] = ret[i - 1, j] + ret[i,j-1];
                    }
                }
            }
            return ret[m-1, n-1];
        }
    }
}
