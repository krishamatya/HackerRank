using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblemSolution
{
   public class NearestMultipleOf5
    {
        public List<int> NearestMultiple(List<int> grades) {
            List<int> finalGrades = new List<int>();
            grades.ForEach(x => {
                if (x >= 38) {
                    int nearestMultiple = x + (5 - (x % 5));
                    if ((nearestMultiple - x) < 3)
                    {
                        finalGrades.Add(nearestMultiple);
                        Console.WriteLine(nearestMultiple);
                    }
                    else if ((nearestMultiple - x) >= 3) {
                        finalGrades.Add(x);
                        Console.WriteLine(x);
                    }
                } else {
                    finalGrades.Add(x);
                    Console.WriteLine(x);
                }
            });
            return finalGrades;
        }
    }
}
