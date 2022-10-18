using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblemSolution
{
  public  class NearestMultipleOf5
    {
        public  string NearestMultiple(int x1, int v1, int x2, int v2)
        {
            if (v2 >= v1)
                return ("NO");
            else
                 if ((x2 - x1) % (v1 - v2) == 0)
                return ("YES");
            else
                return ("NO");


        }
    }
}
