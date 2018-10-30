using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    public class _126WordLadderII
    {
        public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
        {
            var ret = new List<IList<string>>();
            var endWordIndex = -1;
            for (var i = 0; i < wordList.Count; i++)
            {
                if (wordList[i].Equals(endWord))
                {
                    endWordIndex = i;
                    break;
                }
            }
            if (endWordIndex == -1)
            {
                return ret;
            }

            var dict = new Dictionary<string, int>();
            dict.Add(beginWord, 0);
            for(var i = 0; i < wordList.Count; i++)
            {
                if (!dict.ContainsKey(wordList[i]))
                {
                    dict.Add(wordList[i], i + 1);
                }
            }
            var sList = new List<int> {0 };
            var sRet = new List<IList<int>> { new List<int> { 0 } };
            var sUsed = new bool[wordList.Count + 1];
            sUsed[0] = true;
            var tList = new List<int> { endWordIndex + 1};
            var tRet = new List<IList<int>> { new List<int> { endWordIndex + 1 } };
            var tUsed = new bool[wordList.Count + 1];
            tUsed[endWordIndex + 1] = true;
            //var neighbors = new Dictionary<int, List<int>>();
            var intRet = new List<IList<int>>();
            while (sList.Any())
            {
                BFS(sList, sUsed, sRet, dict, wordList.ToList(), beginWord);
                if (isIntersecting(sUsed, tUsed, wordList.ToList(), sRet, tRet, intRet))
                {
                    break;
                }
                BFS(tList, tUsed, tRet, dict, wordList.ToList(), endWord);
                if (isIntersecting(sUsed, tUsed,wordList.ToList(), sRet, tRet, intRet))
                {
                    break;
                }
            }
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

        private bool isIntersecting(bool[] sUsed, bool[] tUsed, List<string> wordList
            , List<IList<int>> sRet, List<IList<int>> tRet, List<IList<int>> intRet)
        {
            var intersected = false;
            for (var i = 0; i < sUsed.Length; i++)
            {
                if (sUsed[i] && tUsed[i])
                {
                    intersected = true;
                    //var commWord = wordList[i - 1];
                    foreach (var s in sRet.Where(sr => sr.Last()==i))
                    {
                        
                        foreach (var t in tRet.Where(tr => tr.Last() == i))
                        {
                            var sTemp = new List<int>(s);
                            var tTemp = new List<int>(t);
                            //tTemp.RemoveRange(tTemp.IndexOf(commWord), tTemp.Count - tTemp.IndexOf(commWord));
                            tTemp.RemoveAt(tTemp.Count - 1);
                            tTemp.Reverse();
                            sTemp.AddRange(tTemp);
                            intRet.Add(sTemp);
                        }
                    }
                }
            }
            return intersected;
        }

        private void BFS(List<int> queue, bool[] used, List<IList<int>> rets,
            Dictionary<string, int> dict, List<string> wordList,
            string beginWord)
        {
            var newNodesIndex = new List<int>();
            //var newNodes = new List<string>();
            foreach (var cur in queue)
            {
                var newRets = new List<IList<int>>();
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
                        if (dict.ContainsKey(newStr) && !used[dict[newStr]])
                        {
                            foreach (var ret in rets.Where(r => r.Last() == cur))
                            {
                                var temp = new List<int>(ret);
                                temp.Add(dict[newStr]);
                                newRets.Add(temp);
                            }
                            //newNodes.Add(newStr);
                            newNodesIndex.Add(dict[newStr]);
                        }
                        chrs[i] = chr_old;
                    }
                }
                //for (var i = 0; i < wordList.Count; i++)
                //{
                //    if (!used[i+1]&&IsLadder(curWord, wordList[i]))
                //    {
                //        //foreach (var ret in rets.Where(r => r.Last() == cur && r.Count == curLevel))
                //        foreach (var ret in rets.Where(r => r.Last() == cur))
                //        {
                //                var temp = new List<int>(ret);
                //                temp.Add(i + 1);
                //                newRets.Add(temp);
                //        }
                //        newNodes.Add(i + 1);
                //    }
                //}
                rets.RemoveAll(r => r.Last() == cur);
                rets.AddRange(newRets);
            }
            queue.Clear();
            queue.AddRange(newNodesIndex.Distinct());
            foreach (var node in newNodesIndex.Distinct())
            {
                used[node] = true;
            }
        }
        private void backtrack(IList<IList<string>> ret, List<string> cur,
            int beginIndex, int endIndex, IList<string> wordList, int[,] ladders)
        {
            var maxLen = ret.Any() ? ret[0].Count : wordList.Count + 1;
            if (cur.Count > maxLen)
            {
                return;
            }
            if (ladders[beginIndex, endIndex] == 1)
            {
                if (cur.Count > maxLen - 1)
                {
                    return;
                }
                cur.Add(wordList[endIndex - 1]);
                if (cur.Count < maxLen)
                {
                    maxLen = cur.Count;
                    ret.Clear();
                }
                ret.Add(new List<string>(cur));
                cur.RemoveAt(cur.Count - 1);
                return;
            }
            if (beginIndex == endIndex)
            {
                if (cur.Count < maxLen)
                {
                    maxLen = cur.Count;
                    ret.Clear();
                }
                ret.Add(new List<string>(cur));
                return;
            }
            for (var i = 0; i < wordList.Count; i++)
            {
                if (ladders[i+1, i+1] != 0)
                {
                    continue;
                }
                if (ladders[i + 1, endIndex] == 1)
                {
                    ladders[i + 1, i + 1] = 1;
                    cur.Add(wordList[i]);
                    backtrack(ret, cur, beginIndex, i+1, wordList, ladders);
                    cur.RemoveAt(cur.Count - 1);
                    ladders[i + 1, i + 1] = 0;
                }
                
            }
        }

        private bool IsLadder(string A, string B)
        {
            var delta = 0;
            for (var i = 0; i < A.Length; i++)
            {
                if (A[i] != B[i])
                {
                    ++delta;
                    if (delta > 1)
                    {
                        return false;
                    }
                }
            }
            return delta == 1;
        }

    }
}
