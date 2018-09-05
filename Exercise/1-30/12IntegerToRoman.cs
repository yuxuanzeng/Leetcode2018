using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _12IntegerToRoman
    {
        public class IntAndRoman
        {
            public int val { get; set; }
            public string roman { get; set; }
        }

        public string IntToRoman(int num)
        {
            var list = new List<IntAndRoman>() {
                new IntAndRoman() { val = 1, roman = "I"},
                new IntAndRoman() { val = 4, roman = "IV"},
                new IntAndRoman() { val = 5, roman = "V"},
                new IntAndRoman() { val = 9, roman = "IX"},
                new IntAndRoman() { val = 10, roman = "X"},
                new IntAndRoman() { val = 40, roman = "XL"},
                new IntAndRoman() { val = 50, roman = "L"},
                new IntAndRoman() { val = 90, roman = "XC"},
                new IntAndRoman() { val = 100, roman = "C"},
                new IntAndRoman() { val = 400, roman = "CD"},
                new IntAndRoman() { val = 500, roman = "D"},
                new IntAndRoman() { val = 900, roman = "CM"},
                new IntAndRoman() { val = 1000, roman = "M"},
            };

            var roman = string.Empty;
            var remain = num;
            var maxIndex = list.Count() - 1;
            while (remain != 0)
            {
                for (var i = maxIndex; i >= 0; i--)
                {
                    if (remain >= list[i].val)
                    {
                        roman += list[i].roman;
                        maxIndex = i;
                        remain = remain - list[i].val;
                        break;
                    }
                }
            }
            return roman;
        }
    }
}
