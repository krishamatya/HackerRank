using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAArray1
{
   public class PlusMinus
    {
        public void FindPlusMinus(List<int> arr) {
          
            decimal positiveCount = 0;
            decimal negativeCount = 0;
            decimal zeroCount = 0;
            int arrayLength = arr.Count;

            positiveCount = arr.Count(x => x > 0);
            negativeCount = arr.Count(x => x < 0);
            zeroCount = arr.Count(x => x == 0);

            
            Console.WriteLine((positiveCount / arrayLength).ToString("N6"));
            Console.WriteLine((negativeCount / arrayLength).ToString("N6"));
            Console.WriteLine((zeroCount / arrayLength).ToString("N6"));
        }
    }
}
