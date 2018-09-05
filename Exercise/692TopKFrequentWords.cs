using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _692TopKFrequentWords
    {
        public class Word : IComparable
        {
            public string word { get; set; }
            public int freq { get; set; }
            public Word(string word, int freq)
            {
                this.word = word;
                this.freq = freq;
            }

            public int CompareTo(object obj)
            {
                var that = (Word)obj;
                if (this.freq == that.freq)
                {
                    return string.Compare(this.word, that.word);
                }
                // descending by freq, ascending by word.
                return that.freq - this.freq;
            }
        }
        public IList<string> TopKFrequent(string[] words, int k)
        {
            var dicts = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (dicts.ContainsKey(word))
                {
                    dicts[word]++;
                }
                else {
                    dicts[word] = 1;
                }
            }
            var sorted = new SortedSet<Word>();
            foreach (var dict in dicts)
            {
                sorted.Add(new Word(dict.Key, dict.Value));
                if (sorted.Count > k)
                {
                    sorted.Remove(sorted.Last());
                }
            }

            return sorted.Select(s => s.word).ToList();
        }
    }
}
