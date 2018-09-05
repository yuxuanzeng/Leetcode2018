using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _7ReverseInteger
    {
        public int Reverse(int x)
        {
            if (x < 10 && x > -10)
            {
                return x;
            }
            //var digitsNum = 0;
            var digits = new List<int>();
            while (x != 0)
            {
                digits.Add(x % 10);
                x = x / 10;
            }
            long newN = 0;
            for (var i = 0; i < digits.Count(); i++)
            {
                newN += digits[i] * (long)Math.Pow(10, digits.Count() - i - 1);
            }
            if (newN > 2147483647 || newN < -2147483648){
                return 0;
            }
            return (int)newN;
        }
    }
}
