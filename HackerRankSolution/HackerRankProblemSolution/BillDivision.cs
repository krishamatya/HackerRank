using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblemSolution
{
   public class BillDivision
    {
        public  void bonAppetite(List<int> bill, int k, int b)
        {
             bill.RemoveAt(k);
             int annabll = bill.Sum() / 2;
            if (annabll == b) {
                Console.WriteLine("Bon Appetit");
            }
            else {
                int returnAmount = b - annabll;
                Console.WriteLine(returnAmount);
            }
        }
    }
}
