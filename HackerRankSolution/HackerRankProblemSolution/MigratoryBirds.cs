using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblemSolution
{
   public class MigratorBirds
    {
        public  int migratoryBirds(List<int> arr)
        {
            
            var duplicates = arr.GroupBy(x => x)
                             .Where(x => x.Count() > 1)
                             .Select(x => new { Item = x.Key, Count = x.Count() }).OrderByDescending(x => x.Count).ToList();

            var maxCount = duplicates.Max(x=>x.Count);
            var minValue = duplicates.Where(x => x.Count == maxCount).Min(x => x.Item);
            return minValue;
        }
    }
}
