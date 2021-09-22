using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxConsecutiveOnes
{
    class Program
    {
        static void Main(string[] args)
        {/* Given a binary array nums, return the maximum number of consecutive 1's in the array.

            Example 1:
            Input: nums = [1,1,0,1,1,1]
            Output: 3
            Explanation: The first two digits or the last three digits are consecutive 1s. The maximum number of consecutive 1s is 3.

            Example 2:
            Input: nums = [1,0,1,1,0,1]
            Output: 2

            Hint:You need to think about two things as far as any window is concerned. One is the starting point for the window. How do you detect that a new window of 1s has started? The next part is detecting the ending point for this window. How do you detect the ending point for an existing window? If you figure these two things out, you will be able to detect the windows of consecutive ones. All that remains afterward is to find the longest such window and return the size.
         */

            //int[] nums = new int[] { 1, 0, 1, 1, 0, 1 };
            //int[] nums = new int[] { 0,0,0,0,0,0};
            //int[] nums = new int[] { 0,0,0,0,0,1};
            int[] nums = new int[] { 1, 1, 0, 1, 1, 1 };
            Console.WriteLine(FindMaxConsecutiveOnes(nums));
            Console.ReadKey();
        }
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int count = 0;
            int max = 0;
            if (nums.Contains(1))
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == 1 && i + 1 != nums.Length)
                    {
                        if (nums[i + 1] == 1)
                        {
                            count++;
                            max = count;
                        }
                        else count = 0;
                    }
                }
                return max + 1;
            }
            else
                return 0;

        }
    }
}
