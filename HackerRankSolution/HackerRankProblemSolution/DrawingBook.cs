using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblemSolution
{
   public class DrawingBook
    {
        public  int pageCount(int n, int p)
        {

            //n total number of pages = 6
            //p page to turn.=3

            int firstTurn = (p / 2);
            int lastTurn = ((n - p) / 2);

            if (n % 2 == 0 && lastTurn == 0 && n != p)
            {
                lastTurn = 1;
            }

            if (firstTurn < lastTurn)
            {
                return firstTurn;
            }
            else
            {
                return lastTurn;
            }


        }
    }
}
