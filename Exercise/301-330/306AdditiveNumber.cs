using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _306AdditiveNumber
    {
        public bool IsAdditiveNumber(string num)
        {
            for (var i = 1; i <= num.Length/2; i++)
            {
                var firstSub = num.Substring(0, i);
                if (num[0] == '0' && i > 1)
                {
                    return false;
                }
                for (var j = 1; j <= num.Length/2; j++)
                {
                    var secSub = num.Substring(i, j);
                    var sumStr = getSumStr(firstSub, secSub);
                    if (i+j >= num.Length
                        || i + j + sumStr.Length > num.Length)
                    {
                        break;
                    }
                    if (num[i] == '0' && j > 1 )
                    {
                        break;
                    }

                    
                    if (!num.Substring(i+j, sumStr.Length).Equals(sumStr))
                    {
                        continue;
                    }
                    if (backtracking(num, i + j + sumStr.Length, secSub, sumStr))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private string getSumStr(string a, string b)
        {
            var ret = new List<char>();
            var carrier = 0;
            var minLen = Math.Min(a.Length, b.Length);
            var numA = a.ToCharArray().Reverse().ToArray();
            var numB = b.ToCharArray().Reverse().ToArray();
            for (var i = 0; i < minLen; ++i)
            {
                var chSum = numA[i] + numB[i] - '0' + carrier;
                carrier = chSum > '9' ? 1 : 0;
                chSum = chSum > '9' ? (chSum - 10) : chSum;
                ret.Add((char)chSum);
            }
            for (var j = minLen; j < b.Length; j++)
            {
                var chSum = numB[j] + carrier;
                carrier = chSum > '9' ? 1 : 0;
                chSum = chSum > '9' ? (chSum - 10) : chSum;
                ret.Add((char)chSum);
            }
            for (var k = minLen; k < a.Length; k++)
            {
                var chSum = numA[k] + carrier;
                carrier = chSum > '9' ? 1 : 0;
                chSum = chSum > '9' ? (chSum - 10) : chSum;
                ret.Add((char)chSum);
            }
            if (carrier != 0)
            {
                ret.Add('1');
            }
            ret.Reverse();
            return new string(ret.ToArray());
        }

        private bool backtracking(string num, int start, string prev1, string prev2)
        {
            if (start >= num.Length)
            {
                return true;
            }
            var sumStr = getSumStr(prev1, prev2);
            if ( (num[start] == '0' && !sumStr.Equals("0") )
                || start + sumStr.Length > num.Length
                || !num.Substring(start, sumStr.Length).Equals(sumStr))
            {
                return false;
            }
            return backtracking(num, start + sumStr.Length, prev2, sumStr);
        }
    }
}
