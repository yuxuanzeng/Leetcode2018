using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _508MostFrequentSubtreeSum
    {
        public Dictionary<int, int> sums = new Dictionary<int, int>();
        public int[] FindFrequentTreeSum(TreeNode root)
        {
            var res = new List<int>();
            if (root == null)
            {
                return res.ToArray();
            }
            GetTreeSum(root);
            var sorted = sums.OrderByDescending(s => s.Value);
            var mostFreqSum = sorted.FirstOrDefault();
            res.Add(mostFreqSum.Key);
            for (var i = 1; i < sorted.Count(); i++) {
                if (sorted.ElementAt(i).Value < mostFreqSum.Value) {
                    break;
                }
                res.Add(sorted.ElementAt(i).Key);
            }
            return res.ToArray();
        }

        public int GetTreeSum(TreeNode root)
        {
            if (root == null) {
                return 0;
            }
            var leftSum = GetTreeSum(root.left);
            var rightSum = GetTreeSum(root.right);
            var sum = leftSum + rightSum + root.val;
            if (sums.ContainsKey(sum))
            {
                sums[sum]++;
            }
            else {
                sums.Add(sum, 1);
            }
            return sum;
        }
    }
}
