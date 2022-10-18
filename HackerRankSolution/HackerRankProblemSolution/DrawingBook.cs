using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblemSolution
{
   public class DrawingBook
    {
        public static int pageCount(int n, int p)
        {

            //n total number of pages = 6
            //p page to turn.=3
            int k = 1;
            int countFirst = 0;
            int countLast = 0;
            for (int i = 1; i <= n; i++) {
                if (Enumerable.Range((k+i), (k+(i+1))).Contains(p)) {
                    countFirst++;
                }  //true 
                k++;
            }
            int l = 0;
            for (int i = n; i <= 1; i--)
            {
                if (Enumerable.Range((i-l), (i-(l-1))).Contains(p))
                {
                    countLast++;
                }  //true 
                k++;

            }
            return 1;
        }
    }
}
