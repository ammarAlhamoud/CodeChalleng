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
        /// implemented by Ammar
        /// </summary>
        /// <param name="nums">The given Array</param>
        /// <param name="target">The sum we are looking for</param>
        /// <returns>An Array with two indeces of elements from nums their sum equals the given target</returns>
        public int[] GetResultByAmmar(int[] nums, int target)
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

        /// <summary>
        /// Return two indecies of the result array
        /// Loop through each element x and find if there is another value that equals to target−x.
        /// </summary>
        /// <param name="nums">The given Array</param>
        /// <param name="target">The sum we are looking for</param>
        /// <returns>An Array with two indeces of elements from nums their sum equals the given target</returns>
        public int[] GetResultBruteForce(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == target - nums[i])
                    {
                        Console.WriteLine("The Result is: [" + i + ", " + j + "]");
                        return new int[] { i, j };
                    }
                }
            }

            Console.WriteLine("There is no answer for the given array");
            return null;
        }
    }
}
