using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _10RegularExpressionMatching
    {
        public bool IsMatch(string s, string p)
        {
            if (string.IsNullOrEmpty(s) && string.IsNullOrEmpty(p))
            {
                return true;
            }
            if (string.IsNullOrEmpty(p))
            {
                return false;
            }
            var dp = new bool[s.Length + 1, p.Length + 1];
            dp[0,0] = true;
            for (var j = 0; j < p.Length; j++)
            {
                if (p[j] == '*' && dp[0, j - 1])
                {
                    dp[0, j + 1] = true;
                }
            }

            for (var i = 0; i < s.Length; i++)
            {
                for (var j = 0; j < p.Length; j++)
                {
                    if (p[j] == '.' || p[j] == s[i])
                    {
                        dp[i + 1, j + 1] = dp[i, j];
                    }
                    else if (p[j] == '*')
                    {
                        if (p[j - 1] != s[i] && p[j - 1] != '.')
                        {
                            dp[i + 1, j + 1] = dp[i + 1, j - 1];
                        }
                        else
                        {
                            dp[i + 1, j + 1] = dp[i + 1, j] || dp[i, j + 1] || dp[i+1, j - 1];
                        }
                    }
                }
            }

            return dp[s.Length, p.Length];
        }
    }
}
