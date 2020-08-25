using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RecursionExercise
{
    public static class Recursion
    {

     /*   public static bool IsPalindrome(string str)
       {
            bool result = false;
            if (str.Length <= 1) return true;
            if (str[0] == str[str.Length - 1]) result = true;
            return IsPalindrome(str.Substring(1, str.Length - 2)) && result;
        }*/

        public static bool IsPalindrome(string str)
        {
            return IsPalindrome(str, 0);
        }

        public static bool IsPalindrome(string str,int index)
        {
            bool result = false;
            if (str.Length / 2 - index <= 0) return true;
            if (str[index] == str[str.Length - 1 - index]) result = true;
            return IsPalindrome(str, index + 1) && result;
        }


        public static int Duplication(int[] arr, int num)
        {
            return Duplication(arr, num, 0);
        }

        private static int Duplication(int[] arr,int num, int index)
        {
            if (index >= arr.Length) return 0;
            if (arr[index] == num) return Duplication(arr, num, index + 1) + 1;
            return Duplication(arr, num, index + 1);
        }

        public static int MinInArr(int[] arr)
        {
            return MinInArr(0, int.MaxValue ,arr);
        }

        private static int MinInArr(int index,int minNum,int[] arr)
        {
            if (index >= arr.Length) return minNum;

            if (arr[index] < minNum) minNum = arr[index];

            return MinInArr(index + 1, minNum, arr);
        }

        public static int SumDigit(int num)
        {
            if(num <= 0) return 0;
            return SumDigit(num / 10) + num % 10;
        }

        public static bool IsPrime(int num)
        {
            return IsPrime(2, (int)Math.Sqrt(num), num);
        }

        private static bool IsPrime(int divideNum, int maxdivideNum, int num)
        {
            if (num == 1 || num == 0)
                return false;
            if (divideNum > maxdivideNum)
                return true;
            if (num % divideNum == 0) return false;
            return IsPrime(divideNum + 1, maxdivideNum, num);
        }

    }
}
