using System;
using System.Linq;

namespace FifteenQ
{
    /// <summary>
    /// "15 essential c# questions"
    /// https://www.toptal.com/c-sharp/interview-questions
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray01 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(LinqArrayEvens(testArray01));

            Console.ReadLine();
        }

        // Question 1 First pass
        static public int LinqArrayEvens(int[] startArray)
        {
            return (from x in startArray where x % 2 == 0 select x).Sum();
        }

        // Question 1 Given Answer
        // Key points: Uses language constructs, accounts for overflow
        static long TotalAllEvenNumbers(int[] intArray)
        {
            return intArray.Where(i => i % 2 == 0).Sum(i => (long)i);
        }
    }
}
