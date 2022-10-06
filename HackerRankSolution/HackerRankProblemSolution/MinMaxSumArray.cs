using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAArray1
{
  public  class MinMaxSumArray
    {
        public void MinMaxSumArrays(List<int> arr) {

            var arr1 = arr.Select(i => (long)i).ToArray();
            Array.Sort(arr1);

            var minimum = arr1.Take(4).Sum();
            var maximum = arr1.Skip(1).Sum();
            Console.WriteLine(minimum + " " +maximum);
           

        }
    }
}
