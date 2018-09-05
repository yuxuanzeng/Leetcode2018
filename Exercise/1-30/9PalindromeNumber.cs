using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _9PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) {
                return false;
            }
            if (x == 0)
            {
                return true;
            }
            if (x % 10 == 0) {
                return false;
            }
            
            var digits = new List<int>();
            while (x > 0) {
                digits.Add( x % 10);
                x = x / 10;
            }
            for (var i = 0; i <= digits.Count() / 2; i++) {
                if (digits[i] != digits[digits.Count() - 1 - i]) {
                    return false;
                }
            }
            return true;
        }
    }
}
