using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _127WordLadder
    {
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            var minLen = 1;
            var dict = new HashSet<string>(wordList);
            if (!dict.Contains(endWord))
            {
                return 0;
            }
            var queue = new Queue<string>();
            queue.Enqueue(beginWord);
            //var found = false;
            var neighbors = new Dictionary<string, List<string>>();
            var used = new HashSet<string>();
            used.Add(beginWord);
            while (queue.Any())
            {
                ++minLen;
                var count = queue.Count;
                for (var i = 0; i < count; i++)
                {
                    var curWord = queue.Dequeue();
                    if (neighbors.ContainsKey(curWord))
                    {
                        continue;
                    }
                    var neighborNodes = new List<string>();
                    for (var ch = 'a'; ch <= 'z'; ch++)
                    {
                        var chrs = curWord.ToCharArray();
                        for (var j = 0; j < chrs.Length; j++)
                        {
                            if (chrs[j] == ch)
                            {
                                continue;
                            }
                            var old_ch = chrs[j];
                            chrs[j] = ch;
                            var newStr = new string(chrs);
                            if (dict.Contains(newStr))
                            {
                                if (!neighbors.ContainsKey(newStr) && !used.Contains(newStr))
                                {
                                    neighborNodes.Add(newStr);
                                    queue.Enqueue(newStr);
                                }
                                if (newStr.Equals(endWord))
                                {
                                    return minLen;
                                }
                                //queue.Push(newStr);
                            }
                            chrs[j] = old_ch;
                        }
                    }
                    neighbors.Add(curWord, neighborNodes);
                }
                foreach (var node in queue)
                {
                    if (!used.Contains(node))
                    {
                        used.Add(node);
                    }
                }
            }
            return 0;
        }
    }
}
