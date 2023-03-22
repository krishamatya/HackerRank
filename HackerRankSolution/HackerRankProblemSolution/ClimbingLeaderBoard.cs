using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblemSolution
{
   public class ClimbingLeaderBoard
    {
        public  List<int> climbingLeaderboard(List<int> ranked, List<int> player)
        {
            ranked.OrderByDescending(x=>x);
            List<int> finalRanking = new List<int>() ;

            int max = ranked.Max();
            int min = ranked.Min();
            var toArray = ranked.ToArray();
            
            player.ForEach(x => {
                if (x >= max)
                {
                    finalRanking.Add(1);
                    return;
                }
                else if (x < min)
                {
                    finalRanking.Add(ranked.IndexOf(min) + 1);
                    return;
                }
                else if (x == min)
                {
                    finalRanking.Add(ranked.IndexOf(min) - 1);
                    return;
                }
                else
                {
                    var array = toArray.OrderBy(t => Math.Abs((long)t - x)).First();
                    var index = 0;
                    if (x > array)
                    {
                        index = ranked.IndexOf(array) - 1;
                    }
                    else if (x < array)
                    {
                        index = ranked.IndexOf(array) + 1;
                    }
                    else
                    {

                        index = ranked.IndexOf(array)+1;
                    }
                   
                    finalRanking.Add(index);
                }

            });

            return finalRanking;
        }
       
    }
}
