using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _126WordLadderII_2
    {
        public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
        {
            var ret = new List<IList<string>>();
            var dict = new Dictionary<string, int>();
            dict.Add(beginWord, 0);
            for (var i = 0; i < wordList.Count; i++)
            {
                if (!dict.ContainsKey(wordList[i]))
                {
                    dict.Add(wordList[i], i + 1);
                }
            }

            if (!dict.ContainsKey(endWord))
            {
                return ret;
            }
            var sList = new List<int> { 0 };
            //var sRet = new List<IList<int>> { new List<int> { 0 } };
            var sUsed = new bool[wordList.Count + 1];
            sUsed[0] = true;
            var neighbors = new Dictionary<int, List<int>>();
            var intRet = new List<IList<int>>();

            BFS(sList, sUsed, dict, wordList, beginWord, endWord, neighbors);
            backtracking(0, dict[endWord], neighbors, new List<int>() { 0 }, intRet);
            //var minLen = intRet.Select(r => r.Count).Min();
            //var tempRet = intRet.Where(r => r.Count == minLen)
            var tempRet = intRet
                .Select(ir => ir.Select(index =>
                {
                    if (index == 0)
                    {
                        return beginWord;
                    }
                    else
                    {
                        return wordList[index - 1];
                    }
                }).ToList()).ToList();
            ret.AddRange(tempRet);
            return ret;
        }

        private void backtracking(int start, int end, Dictionary<int, List<int>> neighbors,
            List<int> curSol, List<IList<int>> ret)
        {
            if (start == end)
            {
                var temp = new List<int>(curSol);
                ret.Add(temp);
                return;
            }

            if (neighbors.ContainsKey(start))
            {
                foreach (var node in neighbors[start])
                {
                    //if (curSol.Contains(node))
                    //{
                    //    continue;
                    //}
                    curSol.Add(node);
                    backtracking(node, end, neighbors, curSol, ret);
                    curSol.RemoveAt(curSol.Count - 1);
                }
            }
            return;
        }

        private void BFS(List<int> queue, bool[] used,
            Dictionary<string, int> dict, IList<string> wordList,
            string beginWord, string endWord, Dictionary<int, List<int>> neighbors)
        {
            var found = false;
            while (queue.Any())
            {
                var count = queue.Count;
                for (var j = 0; j < count; j++)
                {
                    var cur = queue.FirstOrDefault();
                    queue.RemoveAt(0);
                    if (neighbors.ContainsKey(cur))
                    {
                        continue;
                    }
                    var neighborNodes = new List<int>();
                    var curWord = cur == 0 ? beginWord : wordList[cur - 1];
                    var chrs = curWord.ToCharArray();
                    for (var ch = 'a'; ch <= 'z'; ch++)
                    {
                        for (var i = 0; i < chrs.Length; i++)
                        {
                            if (chrs[i] == ch)
                            {
                                continue;
                            }
                            var chr_old = chrs[i];
                            chrs[i] = ch;
                            var newStr = new string(chrs);
                            if (dict.ContainsKey(newStr))
                            {
                                if (!neighbors.ContainsKey(dict[newStr]) && !used[dict[newStr]])
                                {
                                    neighborNodes.Add(dict[newStr]);
                                    queue.Add(dict[newStr]);
                                }
                                if (newStr.Equals(endWord))
                                {
                                    found = true;
                                }
                            }
                            chrs[i] = chr_old;
                        }
                    }
                    //used[cur] = true;
                    neighbors.Add(cur, neighborNodes);
                }
                if (found)
                {
                    return;
                }
                foreach (var node in queue)
                {
                    used[node] = true;
                }
            }
            return;
        }
    }
}
