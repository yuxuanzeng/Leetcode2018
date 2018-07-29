using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _5LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length == 1) {
                return s;
            }

            var maxS = 0;
            var maxE = 0;
            //var step = 0;
            for (var i = 1; i < (s.Length - 1) * 2; i++) {
                var start = i / 2;
                var end = (i + 1) / 2;
                //var step = 0;
                while (start >= 0 && end < s.Length) {
                    if (s[start] == s[end])
                    {
                        start --;
                        end ++;
                    }
                    else {
                        break;
                    }
                }
                start++;
                end--;
                if (end - start > maxE - maxS) {
                    maxS = start;
                    maxE = end;
                }
            }

            return s.Substring(maxS, maxE - maxS + 1);
            //for (var i = 1; i + maxS < s.Length; i++) {
            //    step = 1;
            //    while (i - step >= 0 && i + step < s.Length) {
            //        if (s[i - step] == s[i + step])
            //        {
            //            step++;
            //        }
            //        else {
            //            //step--;
            //            break;
            //        }
            //    }
            //    step--;
            //    if (maxS < step) {
            //        maxI = i;
            //        maxS = step;
            //    }
            //}

            //return s.Substring(maxI - maxS, maxS * 2 + 1);
        }
    }
}
