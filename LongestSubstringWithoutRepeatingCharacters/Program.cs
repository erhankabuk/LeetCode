using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubstringWithoutRepeatingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {/*Given a string s, find the length of the longest substring without repeating characters.
           
            Example 1:
            Input: s = "abcabcbb"
            Output: 3
            Explanation: The answer is "abc", with the length of 3.           
            */
            string s = "abcabcbb";
            Console.WriteLine(LengthOfLongestSubstring(s));
            Console.ReadKey();
        }
        public static int LengthOfLongestSubstring(string s)
        {
            List<char> list = new List<char>();
            List<int> memory = new List<int>();
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                list.Add(s[i]);
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (list.Contains(s[j]))
                    {                       
                            count = list.Count;
                            memory.Add(count);                       
                            list.RemoveRange(0, list.Count);                        
                    }
                    else if (s[i] == s[j])
                    {                       
                            count = list.Count;
                            memory.Add(count);                        
                    }
                }
            }
            Array.Sort(memory.ToArray());
            return memory.Max()+1 ;
        }
    }
}
