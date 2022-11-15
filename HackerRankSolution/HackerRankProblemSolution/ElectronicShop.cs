using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblemSolution
{
    public class ElectronicShop
    {
        public int getMoneySpent(int[] keyboards, int[] drives, int b)
        {

            List<long> option = new List<long>();
            for (int i = 0; i < keyboards.Count(); i++)
            {
                for (int j = 0; j < drives.Count(); j++)
                {
                    var sum = keyboards[i] + drives[j];
                    if (sum <= b)
                    {
                        option.Add(sum);
                    }
                    else if (sum > b)
                    {
                        option.Add(-1);
                    }
                }

            }

            var data = option.Max();
            return Convert.ToInt32(data);
        }
    }
}
