using System;
using System.Collections.Generic;

namespace TwoSum
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
             Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

            You may assume that each input would have exactly one solution, and you may not use the same element twice.

            You can return the answer in any order.

 

            Example 1:

            Input: nums = [2,7,11,15], target = 9
            Output: [0,1]
            Output: Because nums[0] + nums[1] == 9, we return [0, 1].
            */

            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;
            TwoSum(nums, target);
            Console.ReadKey();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int temp = target - nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (temp == nums[j])
                    {
                        result.Add(i);
                        result.Add(j);
                        foreach (var item in result)
                        {
                        Console.WriteLine(item);
                        }
                        return result.ToArray();
                    }
                }
            }
            return null;

        }
    }
}
