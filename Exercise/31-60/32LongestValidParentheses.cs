using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _32LongestValidParentheses
    {
        public int LongestValidParentheses(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return 0;
            }

            var res = 0;
            var stack = new Stack<int>();
            stack.Push(-1);
            for (var i = 0; i < s.Length; i++)
            {
                var top = stack.Peek();
                if (top != -1 && s[i] == ')' && s[top] == '(')
                {
                    stack.Pop();
                    res = Math.Max(res, i - stack.Peek());
                }
                else
                {
                    stack.Push(i);
                }
            }
            return res;
        }
    }
}
