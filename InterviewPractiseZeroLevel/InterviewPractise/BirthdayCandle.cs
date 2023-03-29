using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractise
{
   public class BirthdayCandle
    {
        public  int birthdayCakeCandles(List<int> candles)
        {
            int maxCount = candles.Max();
            int maxC= candles.Count(x => x == maxCount);
            return maxC;
        }
    }
}
