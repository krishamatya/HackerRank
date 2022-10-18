using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblemSolution
{
   public class DivisibleSumPair
    {
        public  int divisibleSumPairs(int n, int k, List<int> ar)
        {
           
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if ( i<j && (ar[i] + ar[j]) % k == 0)
                        {
                            count++;
                        }
                   
                }
            }


            return count;
        }
    }
}
