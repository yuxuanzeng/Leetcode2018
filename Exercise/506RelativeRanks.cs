using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _506RelativeRanks
    {
        public class Athlete
        {
            public Athlete(int index, int score) {
                this.index = index;
                this.score = score;
            }
            public int index { get; set; }
            public int score { get; set; }
            public string ranking { get; set; }
        }
        public string[] FindRelativeRanks(int[] nums)
        {
            var athletes = new List<Athlete>();
            for (var i = 0; i < nums.Length; i++) {
                athletes.Add(new Athlete(i, nums[i]));
            }

            var orderedAth = athletes.OrderByDescending(a => a.score).ToList();
            orderedAth.FirstOrDefault().ranking = "Gold Medal";
            if (orderedAth.Count() >= 2) {
                orderedAth[1].ranking = "Silver Medal";
            }
            if (orderedAth.Count() >= 3) {
                orderedAth[3].ranking = "Bronze Medal";
            }
            for (var i = 3; i < orderedAth.Count(); i++) {
                orderedAth[i].ranking = i.ToString();
            }

            return orderedAth.OrderBy(a => a.index).Select(a => a.ranking).ToArray();
        }
    }
}
