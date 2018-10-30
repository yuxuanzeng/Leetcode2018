using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _89GrayCode
    {
        public IList<int> GrayCode(int n)
        {
            if (n == 0)
            {
                return new List<int>() { 0 };
            }
            
            var ret = new List<int>() { 0, 1};
            for (var i = 2; i <= n; i++)
            {
                var newRet = new List<int>();
                for (var j = ret.Count - 1; j >= 0; j--)
                {
                    newRet.Add(ret[j] + 1 << (i - 1));
                }
                ret.AddRange(newRet);
            }
            //backtrack(ret, 0, n, 1);
            return ret;
        }

        private void backtrack(IList<int> ret, int cur, int len, int pos)
        {
            if (pos > len)
            {
                return;
            }
            for (var i = 0; i < pos; i++)
            {
                if (cur == 1 << (pos - 1))
                {
                    cur += 1 << pos;
                    ret.Add(cur);
                    backtrack(ret, cur, len, pos + 1);
                }

            }
        }
    }
}
