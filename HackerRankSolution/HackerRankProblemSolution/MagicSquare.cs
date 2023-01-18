using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblemSolution
{
    public class MagicSquare
    {

        public  int formingMagicSquare(List<List<int>> s)
        {
            
            return FormMagicSquare(s);
            
        }
        private int FormMagicSquare(List<List<int>> s) {
           
            int minCost = int.MaxValue;
            int[,,]ab = {
               {{8, 1, 6 },{3, 5, 7}, {4, 9, 2 }} ,
               {{6, 1, 8}, {7, 5, 3}, {2, 9, 4}},
               {{4, 9, 2}, {3, 5, 7}, {8, 1, 6}},
               {{2, 9, 4}, {7, 5, 3}, {6, 1, 8}},
               {{8, 3, 4}, {1, 5, 9}, {6, 7, 2}},
               {{4, 3, 8}, {9, 5, 1}, {2, 7, 6}},
               {{6, 7, 2}, {1, 5, 9}, {8, 3, 4}},
               {{2, 7,6 }, {9, 5, 1},  {4, 3, 8 }}
            };
            for (int i = 0; i < 8; i++) {
                int cost = 0;
                for (int j = 0; j < 3; j++) {
                    for (int k = 0; k < 3; k++) {
                       
                        cost += Math.Abs(s[j][k] - ab[i, j, k]);
                    }
                }
                minCost = Math.Min(minCost, cost);
            }

            return minCost;
        }
      


    }
}
