using System;

namespace CodeChalleng
{
    /// <summary>
    /// The startup class for this application
    /// </summary>
    class AppTest
    {
        static void Main(string[] args)
        {
            // first test for consol output
            Console.WriteLine("Hello World!");

            GetTwoSum();
        }

        /// <summary>
        /// Calls the challeng TowSum 
        /// </summary>
        public static void GetTwoSum()
        {
            TwoSum twoSum = new TwoSum();
            ChallengArray array = new ChallengArray();
            int[]  nums = array.CreateArray(20);
            nums = array.FillArray(0, 20, nums);
            Console.Write("Random Array\t" + array.ArrayToString(nums) + "\n");

            int target = 7;
            Console.Write("Target: " + target + "\n");

            Console.WriteLine("By Ammer:\t");
            twoSum.GetResultByAmmar(nums, target);

            Console.WriteLine("---");

            Console.WriteLine("Brute Force:\t");
            twoSum.GetResultBruteForce(nums, target);

            Console.WriteLine("---");

            Console.WriteLine("Hash table:\t");
            twoSum.GetResultByHashMap(nums, target);
        }
    }
}
