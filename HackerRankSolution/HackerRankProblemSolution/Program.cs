using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblemSolution
{
    class Program
    {
        static void Main(string[] args)
        {

            /**** Print PlusMinus ***/

            /*
            List<int> arr = new List<int>() { -4, 3, -9, 0, 4, 1 };
            PlusMinus plusMinus = new PlusMinus();
            plusMinus.FindPlusMinus(arr);
            */

            /*** StairCase***/

            /*
            StairCase stairCase = new StairCase();
            stairCase.StairCasePrint(6);
            */

            /*** MinMaxSumArray***/
            /*
            MinMaxSumArray minMax = new MinMaxSumArray();
            List<int> arr = new List<int> { 256741038, 623958417 ,467905213 ,714532089, 938071625 } ;
            minMax.MinMaxSumArrays(arr);
			*/

            /********BirthdayCandle*******/
            /*
            BirthdayCandles birthdayCandles = new BirthdayCandles();
            Console.WriteLine(birthdayCandles.MaxHeight(new List<int> { 4, 2, 4, 3, 4 }));
            */

            /*****TimeConversion*****/
            /*
            TimeConversion timeConversion = new TimeConversion();
            timeConversion.TimeConvert("07:05:45PM");
            */

            /*****Nearest Multiple*****/
            //num=num+(5-(num%5))
            /*
            NearestMultipleOf5 nearestMultipleOf5 = new NearestMultipleOf5();
            nearestMultipleOf5.NearestMultiple(new List<int> { 73, 67, 38, 33 });
            */

            /*****AppleOranges*****/
            /*AppleOrange apple = new AppleOrange();
            apple.countApplesAndOranges(7, 10, 4, 12, new List<int> { 2, 3, -4 }, new List<int> { 3, -2, -4 });*/
            BetweenTwoSets between = new BetweenTwoSets();
            between.getTotalXX(new List<int> { 2,6}, new List<int> {24,36 });
        }
    }
}
