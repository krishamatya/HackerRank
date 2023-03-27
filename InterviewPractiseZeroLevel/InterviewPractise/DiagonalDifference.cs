using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractise
{
   public class DiagonalDifference
    {
        public  int diagonalDifference(List<List<int>> arr, int n)
        {       
            var sumX = 0;
            var sumY = 0;
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        sumX += arr[j][j];
                    }
                    if ((i + j) == (n - 1))
                    {
                        sumY += arr[i][j];
                    }
                }
            }
            return Math.Abs(sumX - sumY);
        }
    }
}
