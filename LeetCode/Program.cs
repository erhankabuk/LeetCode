using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums. If target exists, then return its index. Otherwise, return -1.
            You must write an algorithm with O(log n) runtime complexity.

            Example 1:
            Input: nums = [-1,0,3,5,9,12], target = 9
            Output: 4
            Explanation: 9 exists in nums and its index is 4*/


            int[] nums = { 9,7,-6,8,2,5,-1,0};
            int target = 8;
            Array.Sort(nums);
            foreach (int item in nums)            
            Console.Write(item+ " ");            
            Console.WriteLine();
            Console.WriteLine(BinarySearch(nums, target));

            Console.ReadKey();

        }

        private static int BinarySearch(int[]nums,int target)
        {
            int pivot, left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                pivot = (left + right) / 2;
                if (target == nums[pivot])
                    return pivot;
                else if (target < nums[pivot])
                    right = pivot - 1;
                else
                    left = pivot + 1;
            }
            return -1;           
        }
    }
}
