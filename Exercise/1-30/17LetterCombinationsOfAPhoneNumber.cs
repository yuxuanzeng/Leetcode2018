using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _17LetterCombinationsOfAPhoneNumber
    {
        public IList<string> LetterCombinations(string digits)
        {
            if (string.IsNullOrEmpty(digits))
            {
                return new List<string>();
            }

            var dict = new Dictionary<int, List<string>>();
            dict.Add(0, new List<string> { " "});
            dict.Add(1, new List<string>());
            dict.Add(2, new List<string> { "a", "b", "c" });
            dict.Add(3, new List<string> { "d", "e", "f" });
            dict.Add(4, new List<string> { "g", "h", "i" });
            dict.Add(5, new List<string> { "j", "k", "l" });
            dict.Add(6, new List<string> { "m", "n", "o"});
            dict.Add(7, new List<string> { "p", "q", "r", "s"});
            dict.Add(8, new List<string> { "t", "u", "v" });
            dict.Add(9, new List<string> { "w", "x", "y", "z"});

            var res = new List<string>();
            foreach (var digit in digits)
            {
                int num = digit - '0';
                res = combineStrLists(res, dict[num]);
            }
            return res;
        }

        private List<string> combineStrLists(List<string> strA, List<string> strB)
        {
            if (strA == null || strA.Count == 0)
            {
                return strB;
            }
            if (strB == null || strB.Count == 0)
            {
                return strA;
            }
            var res = new List<string>();
            foreach (var str in strB)
            {
                foreach (var strr in strA)
                {
                    var temp = strr;
                    temp += str;
                    res.Add(temp);
                }
            }
            return res;
        }

        public IList<string> LetterCombinations2(string digits)
        {
            if (string.IsNullOrEmpty(digits))
            {
                return new List<string>();
            }

            var dicts = new List<string>() {
                " ",
                string.Empty,
                "abc",
                "def",
                "ghi",
                "jkl",
                "mno",
                "pqrs",
                "tuv",
                "wxyz"
            };

            var res = new List<string>() { string.Empty};
            foreach (var digit in digits)
            {
                var str = dicts[digit - '0'];
                var temp = new List<string>();
                foreach (var letter in str)
                {
                    foreach (var resLetter in res)
                    {
                        temp.Add(resLetter + letter.ToString());
                    }
                }
                res = temp;
            }
            return res;
        }
    }
}
