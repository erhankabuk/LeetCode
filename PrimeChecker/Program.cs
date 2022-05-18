using System;
using System.Collections.Generic;

namespace PrimeChecker
{
    class Program
    {
        //Have the function PrimeChecker(num) take num and return 1 if any arrangement of num comes out to be a prime number, otherwise return 0. For example: if num is 910, the output should be 1 because 910 can be arranged into 109 or 019, both of which are primes.

        public static void Main(string[] args)
        {
        //Convert for case   
            PrintResult(
                  Permute(new int[] { 1, 2, 3 })
              );

        }
        static void PrintResult(IList<IList<int>> lists)
        {
            Console.WriteLine("[");
            foreach (var list in lists)
            {
                Console.WriteLine($"    [{string.Join(',', list)}]");
            }
            Console.WriteLine("]");
        }
      


        static IList<IList<int>> Permute(int[] nums)
        {
            var list = new List<IList<int>>();
            return DoPermute(nums, 0, nums.Length - 1, list);
        }

        static IList<IList<int>> DoPermute(int[] nums, int start, int end, IList<IList<int>> list)
        {
            if (start == end)
            {
                // We have one of our possible n! solutions,
                // add it to the list.
                list.Add(new List<int>(nums));
            }
            else
            {
                for (var i = start; i <= end; i++)
                {
                    Swap(ref nums[start], ref nums[i]);
                    DoPermute(nums, start + 1, end, list);
                    Swap(ref nums[start], ref nums[i]);
                }
            }

            return list;
        }

        static void Swap(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }




    }
}


