using System;

namespace Exercise
{
    public class _8StringToInteger
    {
        public int MyAtoi(string str)
        {
            
            if (string.IsNullOrWhiteSpace(str)) {
                return 0;
            }
            var index = 0;
            var negative = false;
            str = str.Trim(' ');
            if (str[0] == '-')
            {
                negative = true;
                index++;
            }
            else if (str[0] == '+') {
                negative = false;
                index++;
            }
            var nums = string.Empty;
            while (index < str.Length && str[index] >= '0' && str[index] <= '9') {
                nums += str[index].ToString();
                index++;
            }
            if (string.IsNullOrEmpty(nums)) {
                return 0;
            }
            nums = nums.TrimStart('0');
            if (nums.Length > 10) {
                if (negative)
                {
                    return int.MinValue;
                }
                else {
                    return int.MaxValue;
                }
            }
            long res = 0;
            for (var i = 0; i < nums.Length; i++) {
                res += (nums[i] - '0') * (long)Math.Pow(10, nums.Length - i - 1);
            }
            if (negative) {
                res = 0 - res;
            }
            if (res > int.MaxValue) {
                return int.MaxValue;
            }
            if (res < int.MinValue) {
                return int.MinValue;
            }
            return (int)res;
        }
    }
}
