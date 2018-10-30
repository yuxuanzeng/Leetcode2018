using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _429NaryTreeLevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(Node root)
        {
            var ret = new List<IList<int>>();
            if (root == null)
            {
                return ret;
            }
            var levelNodes = new Queue<Node>();
            levelNodes.Enqueue(root);
            while (levelNodes.Any())
            {
                var levelValues = new List<int>();
                var count = levelNodes.Count;
                for (var i = 0; i < count; i++)
                {
                    var curNode = levelNodes.Dequeue();
                    levelValues.Add(curNode.val);
                    foreach (var child in curNode.children)
                    {
                        levelNodes.Enqueue(child);
                    }
                }
                ret.Add(levelValues);
            }
            return ret;
        }
    }
}
