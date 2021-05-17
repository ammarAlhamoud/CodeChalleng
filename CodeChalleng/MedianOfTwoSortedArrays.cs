using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChalleng
{
    class MedianOfTwoSortedArrays
    {
        public double findMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] mergedArray = nums1.Concat(nums2).ToArray();
            Array.Sort(mergedArray);

            if(mergedArray.Length % 2 != 0)
            {
                return mergedArray[mergedArray.Length / 2];
            }
            else
            {
                return (double)((mergedArray[mergedArray.Length / 2] + mergedArray[mergedArray.Length/2 - 1]))/2;
            }  
        }
    }
}
