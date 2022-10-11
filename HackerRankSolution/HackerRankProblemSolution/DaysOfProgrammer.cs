using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblemSolution
{
   public class DaysOfProgrammer
    {
        public  string dayOfProgrammer(int year)
        {
            string date = string.Empty;
            int month = 1;
            int totalDays = 0;
            while (totalDays <= 256) {
                 totalDays += DateTime.DaysInMonth(year, month);
                 month += 1;
            }
            int correctDay = 256 - totalDays;
            return string.Format("{0}.{1}.{2}", correctDay, month, year);
        }
    }
}
