using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblemSolution
{
   public class BirthdayCandles
    {
        public int MaxHeight(List<int> candles) {

            var maxValue = candles.Max();
            return candles.Where(x => x == maxValue).Count();
        }
    }
}
