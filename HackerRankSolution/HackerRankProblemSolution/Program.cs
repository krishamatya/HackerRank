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
            /* AppleOrange apple = new AppleOrange();
             apple.countApplesAndOranges(7, 10, 4, 12, new List<int> { 2, 3, -4 }, new List<int> { 3, -2, -4 });
            */
            /****NumberLineJump******/

            /*****NumberLineJump*****/
            /*
            NumberLineJump numberLineJump = new NumberLineJump();
            Console.WriteLine(numberLineJump.kangaroo(0, 2, 5, 3));
            */

            /**** BreakingRecords**********/
            /* BreakingRecords breakingRecords = new BreakingRecords();
             breakingRecords.breakingRecords(new List<int>{ 10, 5, 20, 20, 4, 5, 2, 25, 1 });*/

            /*******SubArray**********/
            /* SubArray subArray = new SubArray();
             subArray.birthday(new List<int> { 2, 2, 1, 3, 2 }, 4, 2);
            */
            /*******DivisibleSumPair**********/
            /*
            DivisibleSumPair di = new DivisibleSumPair();
            di.divisibleSumPairs(100, 21, new List<int>{ 64, 95, 76, 35, 83, 2, 97, 21, 26, 6,
                20, 98, 100, 79, 84 ,40, 62, 62, 20 ,9, 87,
                40, 47, 38, 12, 10, 92, 68, 4, 34, 98, 53, 15,
                4,9,4,77,60,36,49,10,73,56,43,31,6,18,91,53,73,28,90,79,3,72,64,29,89,95,28,23,7,54,23,34,90,100,73,77,98,95,89,22,42,98,39,92,25,44,40,7,100,62,28,25,21,64,55,84,54,99,14,5,51,34,66,4,5,49,56 });
        */
            /****MigratoryBirds****/
            /* MigratorBirds migrator = new MigratorBirds();
             migrator.migratoryBirds(new List<int> { 1, 4, 4, 4, 5, 3 });
            */

            /****DayOfProgramer****/
            /*DaysOfProgrammer dt = new DaysOfProgrammer();
            dt.dayOfProgrammer(1918);
            */

            /****BillDivision****/
            /* BillDivision bill = new BillDivision();
             bill.bonAppetite(new List<int> { 3, 10, 2, 9 }, 1, 7);*/
            /**** SalesByMatch***/
            /* SaleByMatch saleByMatch = new SaleByMatch();
             SaleByMatch.sockMerchant(7, new List<int>() { 10, 20, 20, 10, 10, 30, 50, 10, 20 });
            */
            /**** Amazon Question****/
            /*
            ama1 a = new ama1();
            //a.getHeaviestPackage(new List<int> {20,13,8,9});
            a.find(new List<int> { 1,5,4 });
            */

            //DrawingBook drawing = new DrawingBook();
            //drawing.pageCount(6,5);

            MagicSquare ms = new MagicSquare();
            ms.formingMagicSquare(new List<List<int>>() {
                // ... and fill it line by line 
              new List<int>() {5, 3,  4 },
              new List<int>() {  1,5, 8 },
              new List<int>() { 6,4, 2},
            });
        }
    }
}