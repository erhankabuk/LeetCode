using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {/*          
          Write a function that reverses a string. The input string is given as an array of characters s.
          Example 1:
          Input: s = ["h","e","l","l","o"]
          Output: ["o","l","l","e","h"]
          Example 2:
          Input: s = ["H","a","n","n","a","h"]
          Output: ["h","a","n","n","a","H"]
          Constraints:
          1 <= s.length <= 105
          s[i] is a printable ascii character.
          Follow up: Do not allocate extra space for another array. You must do this by modifying the input array in-place with O(1) extra memory.          
          */
            char[] s = new char[] { 'h', 'e', 'l', 'l', 'o' };
            ReverseString(s);
            Console.ReadKey();
        }

        public static string ReverseString(char[] s)
        {
            /* solution -1
                 Array.Reverse(s);
             */
            List<string> reverseList = new List<string>();
            for (int i = s.Length - 1; i >= 0; i--)
                reverseList.Add(s[i].ToString());

            foreach (var item in reverseList)
                Console.WriteLine(item);

            return reverseList.ToString();
        }
    }
}
