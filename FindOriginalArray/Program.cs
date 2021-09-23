using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindOriginalArray
{
    class Program
    {
        static void Main(string[] args)
        {/* An integer array original is transformed into a doubled array changed by appending twice the value of every element in original, and then randomly shuffling the resulting array.
            Given an array changed, return original if changed is a doubled array. If changed is not a doubled array, return an empty array. The elements in original may be returned in any order.

            Example 1:
            Input: changed = [1,3,4,2,6,8]
            Output: [1,3,4]
            Explanation: One possible original array could be [1,3,4]:
            - Twice the value of 1 is 1 * 2 = 2.
            - Twice the value of 3 is 3 * 2 = 6.
            - Twice the value of 4 is 4 * 2 = 8.
            Other original arrays could be [4,3,1] or [3,1,4].

            Example 2:
            Input: changed = [6,3,0,1]
            Output: []
            Explanation: changed is not a doubled array.

            Example 3:
            Input: changed = [1]
            Output: []
            Explanation: changed is not a doubled array.
            */

            int[] changed = new int[] { 1, 3, 4, 2, 6, 8 };
            //int[] changed = new int[] { 6, 3, 0, 1 };                       
            Console.WriteLine(string.Join(",", FindOriginalArray(changed)));

            Console.ReadKey();
        }

        public static int[] FindOriginalArray(int[] changed)
        {

            int pivot = changed.Length / 2;
            int countLeft = 0;
            int countRight = 0;
            List<int> leftList = new List<int>();
            List<int> rightList = new List<int>();

            for (int i = 0; i < pivot; i++)
                leftList.Add(changed[i]);

            for (int i = pivot; i < changed.Length; i++)
                rightList.Add(changed[i]);

            for (int i = 0; i < pivot; i++)
            {
                if (rightList.Contains(leftList[i] * 2))
                    countLeft++;
                if (leftList.Contains(rightList[i] * 2))
                    countRight++;
            }

            if (countLeft == pivot)
            {
                changed = leftList.ToArray();
                return changed;
            }
            else if (countRight == pivot)
            {
                changed = rightList.ToArray();
                return changed;
            }
            else
                return new int[] { };

        }
    }
}
