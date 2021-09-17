using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedianOfTwoSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {/* Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
            The overall run time complexity should be O(log (m+n)).

            Example 1:
            Input: nums1 = [1,3], nums2 = [2]
            Output: 2.00000
            Explanation: merged array = [1,2,3] and median is 2.

            Example 2:
            Input: nums1 = [1,2], nums2 = [3,4]
            Output: 2.50000
            Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.

            Example 3:
            Input: nums1 = [0,0], nums2 = [0,0]
            Output: 0.00000

            Example 4:
            Input: nums1 = [], nums2 = [1]
            Output: 1.00000

            Example 5:
            Input: nums1 = [2], nums2 = []
            Output: 2.00000            
          */
            int[] nums1 = new int[] { 1, 2 };
            int[] nums2 = new int[] { 3 };
            FindMedianSortedArrays(nums1, nums2);
            Console.ReadKey();
        }
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] z = nums1.Concat(nums2).ToArray();
            Array.Sort(z);
            Console.WriteLine(z.Length);
            double mid = z.Length / 2.00;
            if (mid % 1 != 0)
                return Convert.ToDouble(z[Convert.ToInt32((z.Length - 1) / 2)]);
            else
            {
                int indexOfMid = Convert.ToInt32(mid);
                double temp = z[indexOfMid] + z[indexOfMid - 1];
                return temp / 2.00;
            }
        }
    }
}
