using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveZeros
{
    class Program
    {
        static void Main(string[] args)
        {/*Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
            Note that you must do this in-place without making a copy of the array.
            Example 1:
            Input: nums = [0,1,0,3,12]
            Output: [1,3,12,0,0]
            Example 2:
            Input: nums = [0]
            Output: [0]
            */
            int[] nums = new int[] { 0, 1, 0, 3, 12 };            
            MovesZerosToEnd(nums);
            Console.ReadKey();
        }

        private static void MovesZerosToEnd(int[] nums)
        {
            /*Solution-1
            List<int> list = new List<int>(nums);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Equals(0))
                {
                    list.Add(0);
                    list.Remove(list[i]);
                }
            }
            nums = list.ToArray();
            for (int i = 0; i < nums.Length; i++)
                Console.Write(nums[i]);
            */
            //Solution-2
            int[] arr = new int[nums.Length];
            int count1 = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                 if(nums[i]!=0)
                {
                    arr[count1] = nums[i];
                    count1++;
                }
            }
            for (int i = count1; i < nums.Length; i++)            
                arr[i] = 0;           
            for (int i = 0; i < nums.Length; i++)            
                nums[i] = arr[i];                      
        }
    }
}
