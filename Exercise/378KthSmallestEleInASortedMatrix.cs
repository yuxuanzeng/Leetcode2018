using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _378KthSmallestEleInASortedMatrix
    {
        public class Node
        {
            public Node(int x, int y, int val) {
                this.x = x;
                this.y = y;
                this.val = val;
            }

            public int x { get; set; }
            public int y { get; set; }
            public int val { get; set; }
        }
        public int KthSmallest(int[,] matrix, int k)
        {
            var col = matrix.GetLength(0);
            var row = matrix.GetLength(1);
            var nodes = new List<Node>();

            //var lx = 1;
            //var ly = 0;
            //var dx = 0;
            //var dy = 1;
            var ix = 0;
            var iy = 0;
            var i = 1;
            if (ix < col - 1)
            {
                nodes.Add(new Node(ix + 1, iy, matrix[ix + 1, iy]));
            }
            if (iy < row - 1)
            {
                nodes.Add(new Node(ix, iy + 1, matrix[ix, iy + 1]));
            }
            //var res = matrix[0,0];
            while (i < k) {
                var s = nodes.FirstOrDefault();
                foreach (var node in nodes) {
                    if (s.val > node.val) {
                        s = node;
                        //break;
                    }
                }
                nodes.Remove(s);
                ix = s.x;
                iy = s.y;
                if (s.x < col - 1) {
                    var newNode = new Node(s.x + 1, s.y, matrix[s.x + 1, s.y]);
                    if (!nodes.Exists(n => n.x == newNode.x && n.y == newNode.y))
                    {
                        nodes.Add(newNode);
                    }
                }
                if (s.y < row - 1) {
                    var newNode = new Node(s.x, s.y+1, matrix[s.x, s.y+1]);
                    if (!nodes.Exists(n => n.x == newNode.x && n.y == newNode.y))
                    {
                        nodes.Add(newNode);
                    }
                }

                i++;
            }
            return matrix[ix, iy];
        }
    }
}
