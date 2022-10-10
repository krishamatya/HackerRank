using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblemSolution
{
    public class BreakingRecords
    {
        public  List<int> breakingRecords(List<int> scores)
        {
            int HCount = 0;
            int LCount = 0;
            int MaxValue = scores[0];
            int MinValue = scores[0];
            scores.ForEach(x => {
               
                if (x > MaxValue) {
                    MaxValue = x;
                    HCount++;
                }
                if (x < MinValue) {
                    MinValue = x;
                    LCount++;
                }
            });
            return new List<int> { HCount, LCount };

        }
    }
}
