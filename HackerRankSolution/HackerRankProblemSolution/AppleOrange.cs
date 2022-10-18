using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblemSolution
{
    public class AppleOrange
    {
        public  void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            var TotalAppleCount = 0;
            var TotalOrangeCount = 0;
            apples.ForEach(x => {
                x = a + x;
                if (x >= s && x <= t)
                {
                    TotalAppleCount += 1;
                }
            });
            oranges.ForEach(y => {
                y = b + y;
                if (y >= s && y <= t)
                {
                    TotalOrangeCount += 1;
                }
            });
            Console.WriteLine(TotalAppleCount);
            Console.WriteLine(TotalOrangeCount);
        }


    }
}
