using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaresOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] givenList = new int[] { -4, -1, 0, 3, 10 };
            SortedSquares(givenList);
            Console.ReadKey();
        }


        public static int[] SortedSquares(int[] nums)
        {
            List<int> sqrtArray = new List<int>();
            for (int i = 0; i < nums.Length; i++)
                sqrtArray.Add((int)Math.Pow(nums[i], 2));
            int[] sortedArray = sqrtArray.ToArray();
            Array.Sort(sortedArray);
            for (int i = 0; i < sortedArray.Length; i++)
                Console.WriteLine(sortedArray[i]);
            return sortedArray;

        }
    }
}
