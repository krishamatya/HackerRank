using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblemSolution
{
    public class BetweenTwoSets
    {
       
        public  int getTotalX(List<int> a, List<int> b)
        {
            //1. Find the LCM of a
            //2. Find GCD of b
            //3.Count the number of multiples of LCM that evenly divides the GCD.
           
            int result = 0;
            for (int  i = a[a.Count - 1]; i <= b[0]; i++) {
                int counta = 0;
                int countb = 0;
                a.ForEach(x => {
                    if (i % x == 0) {
                        counta += 1;
                    }
                });
                b.ForEach(x => {
                    if (x % i == 0)
                    {
                        countb += 1;
                    }
                });
                if (counta == a.Count && countb == b.Count) {
                    result++;
                }
              

            }
            return result;
        }
        public int getTotalXX(List<int> a, List<int> b)
        {
            //1. Find the LCM of a
            //2. Find GCD of b
            //3.Count the number of multiples of LCM that evenly divides the GCD.
            int result = 0;

            int lcm= getLCM(a.ToArray(), 0);
            int gcd = GcdOfArray(b.ToArray(), 0);
            int multiple = 0;

            while (multiple <= gcd) {
                multiple += lcm;

                if (gcd % multiple == 0) {
                    result++;
                }

            }
            return result;
        }
        public int GcdOfArray(int[] arr, int idx)
        {
            if (idx == arr.Length - 1)
            {
                return arr[idx];
            }
            int a = arr[idx];
            int b = GcdOfArray(arr, idx + 1);
            return getGCD(a, b);

        }
        public int getLCM(int[] arr, int idx) {
            if(idx == arr.Length - 1) 
            { 
                return arr[idx]; 
            }
            int a = arr[idx];
            int b = getLCM(arr, idx + 1);
            return (a * b / getGCD(a, b));
        }
        public int getGCD(int a, int b) {
            if (a == 0) 
            {
                return b; 
            }
            return getGCD(b % a, a);
        }
    }
}
