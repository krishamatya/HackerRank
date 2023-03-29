using System;
using System.Collections.Generic;

namespace InterviewPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            #region DiagonalDifference
                var data = new List<List<int>>() {
                     // ... and fill it line by line 
                   new List<int>() {-1, 1, -7, -8},
                   new List<int>() {-10, -8, -5, -2},
                   new List<int>() {0, 9, 7, -1},
                    new List<int>() {4, 4, -2, 1},
                 };
                DiagonalDifference d = new DiagonalDifference();
                d.diagonalDifference(data, data.Count);
            #endregion

            #region PlusMinus
            PlusMinus plusMinus = new PlusMinus();
            plusMinus.plusMinus(new List<int>() { -4, 3, -9, 0, 4, 1 });
            #endregion
            
            #region StairCase
            StairCase stairCase = new StairCase();
            stairCase.staircase(6);
            #endregion

            #region MiniMaxSum
            MinMax m = new MinMax();
            m.MiniMaxSum(new List<int>() { 256741038 ,623958417, 467905213, 714532089, 938071625 });
            #endregions*/

            #region BirthdayCandles
            BirthdayCandle candles = new BirthdayCandle();
            candles.birthdayCakeCandles(new List<int>() { 4, 4, 1, 3 });
            #endregion
        }

    }
}
