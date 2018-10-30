using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _118PascalsTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var ret = new List<IList<int>>();

            if (numRows < 1)
            {
                return ret;
            }
            ret.Add(new List<int> { 1 });
            for (var i = 2; i <= numRows; i++)
            {
                var newRow = new List<int>() { 1};
                var lastRow = ret.Last().ToArray();
                for (var j = 1; j < i - 1; j++)
                {
                    newRow.Add(lastRow[j-1] + lastRow[j]);
                }
                newRow.Add(1);
                ret.Add(newRow);
            }

            return ret;
        }
    }
}
