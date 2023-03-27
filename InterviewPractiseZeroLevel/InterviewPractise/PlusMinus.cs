using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractise
{
   public class PlusMinus
    {
        public  void plusMinus(List<int> arr)
        {
            decimal positive = arr.Count(x => x > 0);
            decimal negative = arr.Count(x => x < 0);
            decimal zero = arr.Count(x => x == 0);
            decimal totalCount = arr.Count;



            Console.WriteLine((positive / totalCount).ToString("N6"));
            Console.WriteLine((negative / totalCount).ToString("N6"));
            Console.WriteLine((zero / totalCount).ToString("N6"));

        }
    }
}
