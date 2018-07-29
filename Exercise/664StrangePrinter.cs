using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _664StrangePrinter
    {
        public int StrangePrinter(string s)
        {
            var sb = new StringBuilder();
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            var preC = s[0];
            sb.Append(preC);
            foreach (var c in s)
            {
                if (c == preC) {
                    continue;
                }
                preC = c;
                sb.Append(c);
            }
            var newS = sb.ToString();

            int n = newS.Length;
            var dist = new int[n, n];

            for (int i = n - 1; i >= 0; i--)
            {
                dist[i, i] = 1;
                //dist[i, i + 1] = 2;
                for (int j = i + 1; j < n; j++)
                {
                    dist[i, j] = dist[i, j - 1] + 1;
                    for (int k = i; k < j; k++)
                    {
                        var max = dist[i, k] + dist[k + 1, j];
                        if (newS[k] == newS[j])
                        {
                            max = max - 1;
                        }
                        dist[i, j] = Math.Min(dist[i, j], max);
                    }
                }
            }
            return dist[0, n - 1];

        }
    }
}
