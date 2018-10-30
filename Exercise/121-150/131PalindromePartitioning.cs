using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _131PalindromePartitioning
    {
        public IList<IList<string>> Partition(string s)
        {
            var ret = new List<IList<string>>();
            backtracking(s, 0, new List<string>(), ret);
            return ret;
        }

        private void backtracking(string s, int start, List<string> cur, IList<IList<string>> ret)
        {
            if (start == s.Length)
            {
                ret.Add(new List<string>(cur));
                return;
            }
            for (var i = 1; i <= s.Length - start; i++)
            {
                var subStr = s.Substring(start, i);
                if (!isPalindrome(subStr))
                {
                    continue;
                }
                cur.Add(subStr);
                backtracking(s, start + i, cur, ret);
                cur.RemoveAt(cur.Count - 1);
            }
        }

        private bool isPalindrome(string s)
        {
            for (var i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
