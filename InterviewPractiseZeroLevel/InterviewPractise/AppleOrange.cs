using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractise
{
   public class AppleOrange
    {
        public  void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            var appList = new List<int>();
            var oraList = new List<int>();
            apples.ForEach(x =>
            {
                var newA = a + x;
                appList.Add(newA);
            });
            oranges.ForEach(y => {
                var newB = b + y;
                oraList.Add(newB);
            });
            var appRangeCount = appList.Where(x => x >= s && x <= t).Count();
            Console.WriteLine(appRangeCount);
            var oraRangeCount = oraList.Where(y => y >= s && y <= t).Count();
            Console.WriteLine(oraRangeCount);

        }
    }
}
