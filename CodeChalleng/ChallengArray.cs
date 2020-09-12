using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChalleng
{
    /// <summary>
    /// Class to define a special type of arrays for the challengs
    /// </summary>
    public class ChallengArray
    {
        /// <summary>
        /// Creates an Array of interger with a specific length
        /// </summary>
        /// <param name="length">Length of Array</param>
        /// <returns>Integer Array</returns>
        public int[] CreateArray(int length)
        {
            return new int[length];
        }

        /// <summary>
        /// Fills an Array with numbers
        /// </summary>
        /// <param name="min">The lowest value</param>
        /// <param name="max">The highest value</param>
        /// <param name="array">Array to fill</param>
        /// <returns></returns>
        public int[] FillArray(int min, int max, int[] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(min, max);
            }

            return array;
        }

        /// <summary>
        /// Writes the array in a string 
        /// </summary>
        /// <param name="array">Array to write</param>
        /// <returns>String included the elements of array</returns>
        public string ArrayToString(int[] array)
        {
            string result = "[ ";

            for(int i=0; i < array.Length; i++)
            {
                result += array[i] + " ";
            }

            result += "]";
            return result;
        }
    }
}
