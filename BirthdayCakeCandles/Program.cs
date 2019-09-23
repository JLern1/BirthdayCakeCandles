using System;
using System.Diagnostics;

namespace BirthdayCakeCandles
{
    class Program
    {
        static int birthdayCakeCandles(int[] ar)
        {
            int largestCandle = 0;
            foreach (var i in ar)
            {
                if (i > largestCandle) largestCandle = i;
            }

            int numberOfLargestCandle = 0;
            foreach (var candle in ar)
            {
                if (candle == largestCandle) numberOfLargestCandle++;
            }

            return numberOfLargestCandle;
        }
        static void Main(string[] args)
        {
            int[] ar = {3, 2, 1, 3};
            Debug.Print(birthdayCakeCandles(ar).ToString());
        }
    }
}
