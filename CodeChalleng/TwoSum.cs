using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChalleng
{
    /// <summary>
    /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// You can return the answer in any order
    /// </summary>
    public class TwoSum
    {   
        /// <summary>
        /// Return two indecies of the result array
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] GetResult(int[] nums, int target)
        {
            int[] result = new int[2];
            for(int firstIndex=0; firstIndex<nums.Length; firstIndex++)
            {
                result[0] = firstIndex;
                int secondIndex = firstIndex + 1;
                if (secondIndex > nums.Length-1)
                {
                    Console.WriteLine("Error: Out of rang");
                    throw new IndexOutOfRangeException();
                }

                for(;secondIndex<nums.Length; secondIndex++)
                {
                    int sum = nums[firstIndex] + nums[secondIndex];
                    if (sum == target)
                    {
                        result[1] = secondIndex;
                        Console.WriteLine("The Result is: [" + result[0] + ", " + result[1] + "]");
                        return result;
                    }
                }
            }

            Console.WriteLine("There is no answer for the given array");
            return null;
        }
    }
}
