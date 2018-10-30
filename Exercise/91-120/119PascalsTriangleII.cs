using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _119PascalsTriangleII
    {
        public IList<int> GetRow(int rowIndex)
        {
            var ret = new List<int> { 1 };
            if (rowIndex <= 0) {
                return ret;
            }

            for (var i = 1; i <= rowIndex; i++)
            {
                var temp = new int[i];
                ret.CopyTo(temp, 0);
                for (var j = 1; j < i; j++)
                {
                    ret[j] = temp[j-1] + temp[j];
                }
                ret.Add(1);
            }
            return ret;
        }
    }
}
