using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArray
{
    class Program
    {
        static void Main(string[] args)
        {//Given an array, rotate the array to the right by k steps, where k is non-negative.
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;

            Rotate(nums, k);
            Console.ReadKey();

        }

        public static void Rotate(int[] nums, int k)
        {
            k = k % nums.Length;
            List<int> rotatedArray = new List<int>();
            for (int i = 0; i < nums.Length - k; i++)
            {
                if (i < k)
                    rotatedArray.Add(nums[k + 1 + i]);
                else
                {
                    for (int j = 0; j <= nums.Length - 1 - k; j++)
                        rotatedArray.Add(nums[j]);
                }
            }

            for (int i = 0; i < rotatedArray.Count; i++)
                Console.WriteLine(rotatedArray[i]);
        }
    }
}
