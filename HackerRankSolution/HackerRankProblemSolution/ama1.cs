using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblemSolution
{
   public class ama1
    {
        public long getHeaviestPackage(List<int> packageWeights) {
            int max = 0;
            for (int i = packageWeights.Count - 1; i >= 0; i--) {
                if (packageWeights[i] < max)
                {
                    max += packageWeights[i];
                }
                else {
                    max = packageWeights[i];
                }
            }
            return max;
        }

        public  long find(List<int> rank){
            long imbalance = 0;
             for (int i = 0; i < rank.Count; i++)
                    {
                        for (int j = i; j < rank.Count; j++) {
                           
                         var value = Math.Abs(rank[i] -rank[j]);
                            if (value > 1)
                            {
                                imbalance += 1;
                            }
                        }


                    }
                  
             
           
            return imbalance;
        }
    }
}
