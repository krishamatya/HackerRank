using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblemSolution
{
  public  class CountingValleys
    {
        public  int countingValleys(int steps, string path)
        {
            int cu = 0;
            int cv = 0;
            for (int i = 0; i < steps; i++) {
                if (path[i] == 'U') {
                    cu++;
                   
                    
                } else {
                   
                    cu--;
                }
                if (cu == 0 && path[i] == 'U')
                {
                    cv++;
                }
            }

            return cv;
        }
    }
}
