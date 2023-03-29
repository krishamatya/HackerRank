using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractise
{
   public class MinMax
    {
        public  void MiniMaxSum(List<int> arr)
        {
            var lngArray = arr.ConvertAll(x => (float)x);
            lngArray.Sort();
           // 1,2,3,4,5 Take 4 always minimum as max value already on last
           // skip 1 always maximum as 1 is always minimum
            var mini = lngArray.Take(4).Sum();
            var maxi = lngArray.Skip(1).Sum();
            Console.WriteLine(mini + " " + maxi);

        }
    }
}
