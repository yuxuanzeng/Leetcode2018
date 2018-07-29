using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _6ZigZagConversion
    {
        public string Convert(string s, int numRows)
        {
            if (string.IsNullOrEmpty(s)) {
                return s;
            }
            if (numRows == 1) {
                return s;
            }
            var c = string.Empty;
            for (var r = 0; r < numRows; r++) {
                c += ConvertRow(s, r, numRows);
            }
            return c;
        }

        private string ConvertRow(string s, int row, int numRows)
        {
            var stepD = 0;
            if (row != numRows - 1)
            {
                stepD = (numRows - row - 2) * 2 + 1;
            }
            var stepU = 0;
            if (row != 0)
            {
                stepU = (row - 1) * 2 + 1;
            }

            var c = string.Empty;
            var direction = 0;
            for (var i = row; i < s.Length;) {
                if (direction % 2 == 0 && stepD != 0)
                {
                    c += s[i].ToString();
                    i += (stepD+1);
                }
                else if (direction % 2 == 1 && stepU != 0) {
                    c += s[i].ToString();
                    i += (stepU+1);
                }
                direction++;
            }
            return c;
        }
    }
}
