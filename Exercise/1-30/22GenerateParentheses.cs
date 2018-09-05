using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _22GenerateParentheses
    {
        public IList<string> GenerateParenthesis(int n)
        {
            if (n == 0) return new List<string>();
            if (n == 1) return new List<string>() { "()"};

            var dp = new List<string>[n+1];
            var res = getParentheses(n, dp);
            return res;
        }

        public IList<string> getParentheses(int n, List<string>[] dp)
        {
            if (dp[n] != null)
            {
                return dp[n];
            }
            if (n == 0)
            {
                dp[0] = new List<string>() { ""};
                return dp[0];
            }
            if (n == 1)
            {
                dp[1] = new List<string>() { "()"};
                return dp[1];
            }
            var res = new List<string>();
            for (var i = 0; i <= n - 1; i++)
            {
                var leftP = getParentheses(i, dp);
                var rightP = getParentheses(n - 1 - i, dp);
                foreach (var left in leftP)
                {
                    foreach (var right in rightP)
                    {
                        var parentheses = string.Format("({0}){1}", left, right);
                        res.Add(parentheses);
                    }
                }
            }
            dp[n] = res;
            return res;
        }
    }
}
