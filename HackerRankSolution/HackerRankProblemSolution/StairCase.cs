using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAArray1
{
   public class StairCase
    {
        public void StairCasePrint(int n) {

           
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new String(' ', n-(i-1)) + new string('#', i));
            }
        }
    }
}
