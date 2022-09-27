using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblemSolution
{
   public class TimeConversion
    {
        public string TimeConvert(string s) {
            DateTime dt = DateTime.Parse(s);
            return dt.ToString("HH:mm:ss");
        }
    }
}
