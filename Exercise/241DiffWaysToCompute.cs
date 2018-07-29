using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _241DiffWaysToCompute
    {
        public IList<int> DiffWaysToCompute(string input)
        {
            var res = new List<int>();

            if (string.IsNullOrEmpty(input))
            {
                return res;
            }
            if (input.Length == 1)
            {
                res.Add(Int32.Parse(input));
                return res;
            }

            var nums = input.Split(new char[] { '+', '-', '*'}).Select(n => Int32.Parse(n)).ToList();

            var ops = new List<char>();
            for (var i = 0; i < input.Length; i++)
            {
                if (input[i] == '+' || input[i] == '-' || input[i] == '*')
                {
                    ops.Add(input[i]);
                }
            }

            res.AddRange(DiffWaysToCompute(nums, ops));
            return res;
        }

        public IList<int> DiffWaysToCompute(IEnumerable<int> nums, IEnumerable<char> ops)
        {
            var count = nums.Count();
            var res = new List<int>();
            if (count == 1)
            {
                res.Add(nums.ElementAt(0));
                return res;
            }
            if (count == 2)
            {
                res.Add(Operate(nums.ElementAt(0), nums.ElementAt(1), ops.ElementAt(0)));
                return res;
            }
            var j = 1;
            while (j <= count - 1)
            {
                var leftNums = DiffWaysToCompute(nums.Take(j), ops.Take(j-1));
                var rightNums = DiffWaysToCompute(nums.Skip(j).Take(count - j), ops.Skip(j).Take(count - j - 1));
                var results = Operate(leftNums, rightNums, ops.ElementAt(j-1));
                res.AddRange(results);
                j++;
            }
            return res;
        }

        public int Operate(int a, int b, char op)
        {
            if (op == '+')
            {
                return a + b;
            }
            else if (op == '-')
            {
                return a - b;
            }
            else
            {
                return a * b;
            }
        }

        public IList<int> Operate(IList<int> a, IList<int> b, char op)
        {
            if (op == '+')
            {
                return Add(a, b);
            }
            else if (op == '-')
            {
                return Minus(a, b);
            }
            else
            {
                return Time(a, b);
            }
        }
        public IList<int> Add(IList<int> a, IList<int> b)
        {
            var res = new List<int>();
            foreach (var num in a)
            {
                foreach (var dig in b)
                {
                    res.Add(num + dig);
                }
            }

            return res;
        }

        public IList<int> Minus(IList<int> a, IList<int> b)
        {
            var res = new List<int>();
            foreach (var num in a)
            {
                foreach (var dig in b)
                {
                    res.Add(num - dig);
                }
            }

            return res;
        }

        public IList<int> Time(IList<int> a, IList<int> b)
        {
            var res = new List<int>();
            foreach (var num in a)
            {
                foreach (var dig in b)
                {
                    res.Add(num * dig);
                }
            }
            return res;
        }
    }
}
