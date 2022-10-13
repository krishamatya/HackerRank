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
            int month = 1;
            int totaldays = 0;
            bool isLeapYear = false;

            if (year <= 1917)
            {
                isLeapYear = year % 4 == 0 ? true : false;
            }
                    while (totaldays < 256)
                    {
                        var days = DateTime.DaysInMonth(year, month); 
                        if (year <= 1917 && isLeapYear && month == 2) {
                            if (days == 28) {
                                days += 1;    
                            }
                        }
                        if (year == 1918 && month == 2) {
                                 days -= 13;
                        }
                        totaldays += days;
                        month += 1;
                        if (256 - totaldays < 30)
                        {
                            break;
                        }


                    }
                    string monthFinal = month < 10 ? "0" + month : Convert.ToString(month);
                    int actualdate = 256 - totaldays;
                    string actualdateFinal = actualdate < 10 ? "0" + actualdate : actualdate.ToString();
                    return String.Format("{0}.{1}.{2}", actualdateFinal, monthFinal, year);
               
           
        }
    }
}
