using System;
using System.Collections.Generic;

namespace Exercise
{
    public class _812LargestTriangleArea
    {
        public double LargestTriangleArea(int[][] points)
        {
            double maxArea = 0;
            var triangles = GetPossibleTriangles(points.Length);
            foreach (var triangle in triangles)
            {
                var p1 = points[triangle[0]];
                var p2 = points[triangle[1]];
                var p3 = points[triangle[2]];
                if ((p1[0] == p2[0] && p2[0] == p3[0])
                    || (p1[1] == p2[1] && p2[1] == p3[1]))
                {
                    continue;
                }
                var area = GetTriangleArea(p1, p2, p3);
                if (area > maxArea)
                {
                    maxArea = area;
                }
            }

            return maxArea;
        }

        public List<int[]> GetPossibleTriangles(int length)
        {
            var res = new List<int[]>();
            for (var i = 0; i < length; i++)
            {
                //var pointSet = new List<int>();
                //pointSet.Add(i);
                for (var j = i + 1; j < length; j++)
                {
                    //pointSet.Add(j);
                    for (var k = j + 1; k < length; k++)
                    {
                        //pointSet.Add(k);
                        var pointSet = new List<int>() { i, j, k };
                        res.Add(pointSet.ToArray());
                    }
                }
            }
            return res;
        }

        public double GetTriangleArea(int[] p1, int[] p2, int[] p3)
        {
            
            double y1 = Math.Abs(p1[1] - p2[1]);
            double y2 = Math.Abs(p1[1] - p3[1]);
            double y3 = Math.Abs(p2[1] - p3[1]);

            double x1 = Math.Abs(p1[0] - p2[0]);
            double x2 = Math.Abs(p1[0] - p3[0]);
            double x3 = Math.Abs(p2[0] - p3[0]);

            double extraArea = 0;
            var ey2 = Math.Max(p1[1], Math.Max(p2[1],p3[1]));
            var ey1 = Math.Min(p1[1], Math.Min(p2[1],p3[1]));
            var ex1 = Math.Min(p1[0], Math.Min(p2[0],p3[0]));
            var ex2 = Math.Max(p1[0], Math.Max(p2[0],p3[0]));

            if (p1[0] != ex1 && p1[0] != ex2 && p1[1] != ey1 && p1[1] != ey2) {
                if (p1[1] - ey1 > ((ey2 - ey1) / (ex2 - ex1)) * (p1[0] - ex1))
                {
                    var height = ey2 - p1[1];
                    var width = p1[0] - ex1;
                    extraArea = height * width;
                }
                else
                {
                    var height = p1[1] - ey1;
                    var width = ex2 - p1[0];
                    extraArea = height * width;
                }
            }
            else if (p2[0] != ex1 && p2[0] != ex2 && p2[1] != ey1 && p2[1] != ey2)
            {
                if (p2[1] - ey1 > ((ey2 - ey1) / (ex2 - ex1)) * (p2[0] - ex1))
                {
                    var height = ey2 - p2[1];
                    var width = p2[0] - ex1;
                    extraArea = height * width;
                }
                else
                {
                    var height = p2[1] - ey1;
                    var width = ex2 - p2[0];
                    extraArea = height * width;
                }
            }
            else if (p3[0] != ex1 && p3[0] != ex2 && p3[1] != ey1 && p3[1] != ey2)
            {
                if (p3[1] - ey1 > ((ey2 - ey1) / (ex2 - ex1)) * (p3[0] - ex1))
                {
                    var height = ey2 - p3[1];
                    var width = p3[0] - ex1;
                    extraArea = height * width;
                }
                else
                {
                    var height = p3[1] - ey1;
                    var width = ex2 - p3[0];
                    extraArea = height * width;
                }
            }

            var recArea = (ey2-ey1) * (ex2-ex1);
            double triArea = recArea - (double)(y1 * x1 / 2) - (double)(y2 * x2 / 2) - (double)(y3 * x3 / 2) - extraArea;
            return triArea;
        }
    }
}
