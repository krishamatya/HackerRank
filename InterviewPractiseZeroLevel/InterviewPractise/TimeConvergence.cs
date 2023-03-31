using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractise
{
  public  class TimeConvergence
    {
        public  string timeConversion(string s)
        {
            return DateTime.Parse(s).ToString("HH:mm:ss");
        }
    }
}
