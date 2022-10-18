using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblemSolution
{
   public class SubArray
    {
        public  int birthday(List<int> s, int d, int m)
        {
            int count = 0;
            for (int i = 0; i < s.Count; i++)
            {
                var sum = s.Skip(i).Take(m).Sum();
                if (sum == d) {
                    count++;
                }
            }
            return count;
        }
    }
}
