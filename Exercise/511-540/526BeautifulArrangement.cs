using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _526BeautifulArrangement
    {
        public int CountArrangement(int N)
        {
            var ret = 0;
            ret = backtracking(N, new bool[N+1], 1);
            return ret;
        }

        private int backtracking(int N, bool[] used, int cur)
        {
            if (cur > N)
            {
                return 1;
            }
            var ret = 0;
            for (var i = 1; i <= N; i++)
            {
                if ((cur%i != 0 && i%cur != 0) || used[i])
                {
                    continue;
                }
                used[i] = true;
                ret += backtracking(N, used, cur + 1);
                used[i] = false;
            }
            return ret;
        }
    }
}
