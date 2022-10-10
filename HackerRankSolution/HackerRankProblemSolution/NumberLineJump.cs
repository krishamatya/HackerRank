using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblemSolution
{
   public class NumberLineJump
    {
       // Velocity = distance/time = distance./jump
       //d= vXjump
       // x1+v1XJ = x2+v2XJ
       //v1XJ-v2XJ = (x2-x1)
       //J(v1-v2)=(x2-x1) => (x2-x1)/(v1-v2) => integer values //remainder should be 0 => (x2-x1)%(v1-v2) == 0

       
        public  string kangaroo(int x1, int v1, int x2, int v2)
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
