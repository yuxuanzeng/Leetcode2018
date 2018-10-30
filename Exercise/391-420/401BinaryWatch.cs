using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _401BinaryWatch
    {
        public IList<string> ReadBinaryWatch(int num)
        {
            var ret = new List<string>();
            backtracking(num, 0, 1, ret);
            return ret;
        }

        private void backtracking(int num, int cur, int start, List<string> ret)
        {
            if (hasOnes(cur) == num)
            {
                if (cur % 64 >= 60 || cur / 64 >= 12)
                {
                    return;
                }
                ret.Add(toTimeString(cur));
                return;
            }
            for (var i = start; i <= 512; i = i * 2)
            {
                if ((cur & i) == i)
                {
                    continue;
                }
                cur += i;
                backtracking(num, cur, i*2, ret);
                cur -= i;
            }
        }

        private int hasOnes(int n)
        {
            var count = 0;
            while (n != 0)
            {
                if (n % 2 == 1)
                {
                    ++count;
                }
                n = n / 2;
            }
            return count;
        }

        private string toTimeString(int n)
        {
            var hours = n / 64;
            var mins = n % 64;
            var timeStr = hours.ToString() + ":" + mins.ToString("D2");
            //var minStr = mins.ToString();
            return timeStr;
        }
    }
}
