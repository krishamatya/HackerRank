using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractise
{
   public class StairCase
    {
        
        public  void staircase(int n)
        {

            int count = n-1;
            for (int i = 1; i <= n; i++)
            {

                var print = new string(' ', count) + new string('#', i);
                Console.WriteLine(print);
                count--;
            }
        }
    }
}
