using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionOfTwoArraysII
{
    class Program
    {
        static void Main(string[] args)
        { /*Given two integer arrays nums1 and nums2, return an array of their intersection. Each element in the result must appear as many times as it shows    in  both arrays and you may return the result in any order.          
            Example 1:
            Input: nums1 = [1,2,2,1], nums2 = [2,2]
            Output: [2,2]
            
            Example 2:
            Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
            Output: [4,9]
            Explanation: [9,4] is also accepted.            
          */

            int[] nums1 = new int[] { 4, 9, 5 };
            int[] nums2 = new int[] { 9, 4, 9, 8, 4 };
            //int[] nums1 = new int[] { 1, 2, 2, 1 };
            //int[] nums2 = new int[] { 2, 2 };
            Intersect(nums1, nums2);
            Console.ReadKey();
        }

        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            int nums1Length = nums1.Length;
            int nums2Length = nums2.Length;
            List<int> intersectOfArrays = new List<int>();
            if (nums1Length >= nums2Length)
            {
                for (int j = 0; j < nums2Length; j++)
                {
                    if (nums1.Contains(nums2[j]))
                        intersectOfArrays.Add(nums2[j]);
                }
            }
            else
            {
                for (int j = 0; j < nums1Length; j++)
                {
                    if (nums2.Contains(nums1[j]))
                        intersectOfArrays.Add(nums1[j]);
                }
            }
            foreach (var item in intersectOfArrays)
                Console.WriteLine(item);

            return intersectOfArrays.ToArray();
        }
    }
}
