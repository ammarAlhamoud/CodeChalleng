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

            TwoSum twoSum = new TwoSum();
            int[] nums = new int[] {2, 7, 11, 15, 1, 12, 15, 22 , 103, 66};
            int target = 23;
            twoSum.GetResult(nums, target);
        }
    }
}
