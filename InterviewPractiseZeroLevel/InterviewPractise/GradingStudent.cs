using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractise
{
  public  class GradingStudent
    {
        public  List<int> gradingStudents(List<int> grades)
        {
            List<int> finalCollection = new List<int>();
            
            foreach (var x in grades) {
                var decX = Convert.ToDecimal(x);
                var y = Convert.ToInt32(Math.Ceiling(decX / 5) * 5);
                if (x < 38)
                {
                    finalCollection.Add(x);
                }
                else if ((y - x) < 3)
                {
                    finalCollection.Add(y);
                }
                else if ((y - x) >= 3)
                {
                    finalCollection.Add(x);
                }
              
                




            }
            return finalCollection;
        }
    }
}
