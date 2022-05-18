using System;

namespace SimpleMode
{
    class Program
    {
        //Have the function SimpleMode(arr) take the array of numbers stored in arr and return the number that appears most frequently (the mode). For example: if arr contains[10, 4, 5, 2, 4] the output should be 4. If there is more than one mode return the one that appeared in the array first (ie. [5, 10, 10, 6, 5] should return 5 because it appeared first). If there is no mode return -1. The array will not be empty.
        static void Main(string[] args)
        {
            int[] input = { 10, 4, 5, 2, 4 };
            //int[] input = { 5, 10, 10, 6, 5 };
            Console.WriteLine(ArrayChallenge(input));
        }

        public static int ArrayChallenge(int[] arr)
        {

            int count = 1, temp = 1;
            int mod;
            int res = -1;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                mod = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (mod == arr[j]) count++;
                }

                if (count > temp)
                {
                    res = mod;
                    temp = count;
                }
                count = 1;

            }

            return res;
        }

    }
}

