using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _784LetterCasePermutation
    {
        public IList<string> LetterCasePermutation(string S)
        {
            var ret = new List<string>();
            backtrack(ret, new List<char> (),S.ToCharArray(), 0);
            if (ret.Count == 0)
            {
                ret.Add(S);
            }
            return ret;
        }

        private void backtrack(IList<string> ret, List<char> prev, char[] S, int pos)
        {
            var cur = new List<char>(prev);
            for (var i = pos; i < S.Length; i++)
            {
                if (S[i] >= 48 && S[i] <= 57)
                {
                    cur.Add(S[i]);
                    continue;
                }
                var transLetter = 'a';
                if (S[i] >= 'a' && S[i] <= 'z')
                {
                    transLetter = (char)(S[i] + 'A' - 'a');
                }
                else if (S[i] >= 'A' && S[i] <= 'Z')
                {
                    transLetter = (char)(S[i] + 'a' - 'A');
                }
                cur.Add(transLetter);
                backtrack(ret, cur, S, i + 1);
                cur.RemoveAt(cur.Count - 1);
                cur.Add(S[i]);
            }
            ret.Add(string.Concat(cur));
        }
    }
}
