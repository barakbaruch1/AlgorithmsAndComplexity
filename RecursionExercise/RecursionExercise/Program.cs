using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace RecursionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Is Palindrome:");
            Console.WriteLine(Recursion.IsPalindrome("aba"));
            Console.WriteLine(Recursion.IsPalindrome("qaz"));
            Console.WriteLine(Recursion.IsPalindrome("a"));
            Console.WriteLine(Recursion.IsPalindrome("AB"));
            Console.WriteLine(Recursion.IsPalindrome("ABBA"));
            Console.WriteLine(Recursion.IsPalindrome("ABBB"));

            Console.WriteLine("Is Prime:");
   //         Console.WriteLine(IsPrime(6));
            Console.WriteLine(Recursion.IsPrime(25));

            Console.WriteLine("Sum Digits:");
            Console.WriteLine(Recursion.SumDigit(25));
            Console.WriteLine(Recursion.SumDigit(2));
            Console.WriteLine(Recursion.SumDigit(0));
            Console.WriteLine(Recursion.SumDigit(101));

            Console.WriteLine("Min In Arr");
            int[] arr = { 5, 2, 3, 7 };
            int[] arr1 = {2,2,2,3};
            Console.WriteLine(Recursion.MinInArr(arr));
            Console.WriteLine(Recursion.MinInArr(arr1));
            
            Console.WriteLine("Duplication:");
            Console.WriteLine(Recursion.Duplication(arr1, 2));

            Console.ReadLine();
        }


    }
}
