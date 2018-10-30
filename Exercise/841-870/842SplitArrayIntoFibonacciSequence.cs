using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _842SplitArrayIntoFibonacciSequence
    {
        public IList<int> SplitIntoFibonacci(string S)
        {
            var ret = new List<int>();

            for (var i = 1; i <= S.Length / 2; i++)
            {
                if (S[0] == '0' && i > 1)
                {
                    break;
                }
                var firstSub = S.Substring(0,i);
                int firstNum;
                if (!Int32.TryParse(firstSub, out firstNum))
                {
                    break;
                }
                ret.Add(firstNum);
                for (var j = 1; j <= S.Length / 2; j++)
                {
                    if (S[i] == '0' && j > 1)
                    {
                        break;
                    }
                    var secSub = S.Substring(i, j);
                    int secNum;
                    if (!Int32.TryParse(secSub, out secNum))
                    {
                        break;
                    }
                    long sum = firstNum + secNum;
                    if (sum > Int32.MaxValue)
                    {
                        break;
                    }
                    var sumStr = sum.ToString();
                    if (i + j > S.Length
                        || i + j + sumStr.Length > S.Length)
                    {
                        break;
                    }
                    if ( !S.Substring(i + j, sumStr.Length).Equals(sumStr))
                    {
                        continue;
                    }
                    ret.Add(secNum);
                    ret.Add((int)sum);
                    if (backtracking(S, i + j + sumStr.Length, secNum, (int)sum, ret))
                    {
                        return ret;
                    }
                    ret.RemoveAt(2);
                    ret.RemoveAt(1);
                }
                ret.Clear();
            }
            return ret;
        }

        public bool backtracking(string num, int start, int prev1, int prev2, IList<int> ret)
        {
            if (start >= num.Length)
            {
                return true;
            }
            long sum = prev1 + prev2;
            if (sum > Int32.MaxValue)
            {
                return false;
            }
            if (sum != 0 && num[start] == '0')
            {
                return false;
            }
            var sumStr = sum.ToString();
            if (start + sumStr.Length > num.Length
                || !num.Substring(start, sumStr.Length).Equals(sumStr))
            {
                return false;
            }
            ret.Add((int)sum);
            if (!backtracking(num, start + sumStr.Length, prev2, (int)sum, ret))
            {
                ret.RemoveAt(ret.Count - 1);
                return false;
            }
            return true;
        }
    }
}
