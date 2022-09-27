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
            AppleOrange apple = new AppleOrange();
            apple.countApplesAndOranges(7, 10, 4, 12, new List<int> { 2, 3, -4 }, new List<int> { 3, -2, -4 });
        }
    }
}
