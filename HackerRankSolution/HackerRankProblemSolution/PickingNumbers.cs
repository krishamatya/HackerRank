using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblemSolution
{
   public class PickingNumbers
    {
        public  int pickingNumbers(List<int> a)
        {
            // group by removes duplicatees ie 4,6,5,3,3,1
            // g.count() = 1
            // a.Count(x=> x==g.Key()+1)=> a.Count( x=> 5 == (4+1)) = 1+1
            //                          => a.Count(x=>7 == (6+1)) = 1+0
            //                          => a.Count(x=> 6 == (5+1)) = 1+1
            //                          => a.Count(x=> 4 == (3+1)) = 1+2
            //                          => a.Count(x=> 2 == (1+1)) = 1+1
            var xx = a.GroupBy(x => x).Select(
                g => g.Count() + a.Count(x => x == g.Key + 1)).Max();         
            return xx;
        }
    }
}
