using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _20ValidParentheses
    {
        public bool IsValid(string s)
        {
            var pipe = new Stack<char>();
            if (s.Length % 2 != 0)
            {
                return false;
            }
            foreach (var c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    pipe.Push(c);
                }
                else
                {
                    if (pipe.Count == 0)
                    {
                        return false;
                    }
                    var parenthese = pipe.Pop();
                    if ( (parenthese == '(' && c != ')')
                        || (parenthese == '[' && c!= ']')
                        || (parenthese == '{' && c!= '}')
                        )
                    {
                        return false;
                    }
                }
            }
            return pipe.Count == 0;
        }
    }
}
