using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblemSolution
{
   public class SaleByMatch
    {
        public static int sockMerchant(int n, List<int> ar)
        {
            int sum = 0;
            ar.Sort();
            var br = ar.GroupBy(x => x).Where(x => x.Count() > 1).Select(x=>new { Item = x.Key, Count = x.Count() }).ToList();
            br.ForEach(x => {
                var vy =(int)x.Count / 2;
                sum += vy;
            });
            return sum;
        }
    }
}
