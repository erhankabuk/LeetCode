using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {/* You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n,  representing the number of elements in nums1 and nums2 respectively.
            Merge nums1 and nums2 into a single array sorted in non-decreasing order.
            The final sorted array should not be returned by the function, but instead be stored inside the array nums1. To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.

            Example 1:
            Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
            Output: [1,2,2,3,5,6]
            Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
            The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.

            Example 2:
            Input: nums1 = [1], m = 1, nums2 = [], n = 0
            Output: [1]
            Explanation: The arrays we are merging are [1] and [].
            The result of the merge is [1].

            Example 3:
            Input: nums1 = [0], m = 0, nums2 = [1], n = 1
            Output: [1]
            Explanation: The arrays we are merging are [] and [1].
            The result of the merge is [1].
            Note that because m = 0, there are no elements in nums1. The 0 is only there to ensure the merge result can fit in nums1.
        */
            /*
            int[] nums1 = new int[] { 0 };
            int[] nums2 = new int[] { 1 };
            int m = 0;
            int n = 1;
             */

            int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = new int[] { 2, 5, 6 };
            int m = 3;
            int n = 3;

            Merge(nums1, m, nums2, n);
            Console.ReadKey();

        }
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            Array.Resize(ref nums1, m + n);

            for (int j = 0; j < n; j++)
                nums1[m + j] = nums2[j];

            Array.Sort(nums1);

            foreach (int item in nums1)
                Console.WriteLine(item);
        }

    }
}
