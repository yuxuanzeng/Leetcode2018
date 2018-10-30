using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _743NetworkDelayTime
    {
        public int NetworkDelayTime(int[,] times, int N, int K)
        {
            var len = times.GetLength(0);
            if (times.GetLength(0) < N - 1)
            {
                return -1;
            }
            var dist = new int[N+1];
            for (var i = 0; i < N+1; i++)
            {
                dist[i] = Int32.MaxValue;
            }
            dist[K] = 0;
            for (var i = 0; i < N; i++)
            {
                for (var j = 0; j < len; j++)
                {
                    var sourceNode = times[j, 0];
                    var destNode = times[j, 1];
                    var time = times[j, 2];

                    if (dist[sourceNode] != Int32.MaxValue
                        && dist[destNode] > dist[sourceNode] + time)
                    {
                        dist[destNode] = dist[sourceNode] + time;
                    }
                }
            }

            var max = 0;
            for (var i = 1; i < N + 1; i++)
            {
                if (dist[i] > max)
                {
                    max = dist[i];
                }
            }

            return max == Int32.MaxValue ? -1 : max;
        }
    }
}
