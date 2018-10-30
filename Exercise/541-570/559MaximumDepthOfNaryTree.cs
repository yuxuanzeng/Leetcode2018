using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _559MaximumDepthOfNaryTree
    {
        public int MaxDepth(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            var ret = 1;
            foreach (var child in root.children)
            {
                var temp = 1 + MaxDepth(child);
                if (temp > ret)
                {
                    ret = temp;
                }
            }
            return ret;
        }
    }
}
