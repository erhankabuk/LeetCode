using System;

namespace JumpGame
{
    class Program
    {
        static void Main(string[] args)
        {
            /*You are given an integer array nums. You are initially positioned at the array's first index, and each element in the array represents your maximum jump length at that position.

                Return true if you can reach the last index, or false otherwise.                 
                
                Example 1:
                
                Input: nums = [2,3,1,1,4]
                Output: true
                Explanation: Jump 1 step from index 0 to 1, then 3 steps to the last index.
                Example 2:
                
                Input: nums = [3,2,1,0,4]
                Output: false
                Explanation: You will always arrive at index 3 no matter what. Its maximum jump length is 0, which makes it impossible to reach the last index.
            */

            int[] input1 = new int[] { 2, 3, 1, 1, 4 };//true
            int[] input2 = new int[] { 3, 2, 1, 0, 4 };//false
            int[] input3 = new int[] {  0, 1 };//false

            Console.WriteLine(CanJump(input3));
            Console.ReadKey();
        }

        public static bool CanJump(int[] nums)
        {

            int length = nums.Length;

            for(int i =0; i<length; i++)
            {
                if (nums[i] <= length - 2) return false;
                if (i == length - 1) return true;
                
                else if (nums[i] <= length - 1)
                {
                    i = nums[i] - 1;
                    length = nums[i] + 1;
                }
              



            }

            return false;
        }
    }
}
