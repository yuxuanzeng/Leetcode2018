using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _392IsSubsequence
    {
        public bool IsSubsequence(string s, string t)
        {
            if (string.IsNullOrEmpty(s)) {
                return true;
            }
            if (string.IsNullOrEmpty(t)) {
                return false;
            }

            var indexS = 0;
            for (var i = 0; i < t.Length; i++) {
                if (t[i] == s[indexS]) {
                    indexS++;
                    if (indexS >= s.Length) {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
