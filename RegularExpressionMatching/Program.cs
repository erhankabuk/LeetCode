using System;

namespace RegularExpressionMatching
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*Given an input string s and a pattern p, implement regular expression matching with support for '.' and '*' where:

            '.' Matches any single character.​​​​
            '*' Matches zero or more of the preceding element.
            The matching should cover the entire input string (not partial).

 

            Example 1:

            Input: s = "aa", p = "a"
            Output: false
            Explanation: "a" does not match the entire string "aa".
            Example 2:

            Input: s = "aa", p = "a*"
            Output: true
            Explanation: '*' means zero or more of the preceding element, 'a'. Therefore, by repeating 'a' once, it becomes "aa".
            Example 3:

            Input: s = "ab", p = ".*"
            Output: true
            Explanation: ".*" means "zero or more (*) of any character (.)".
            */

            Console.WriteLine(IsMatch("aa", ".*"));
            Console.ReadKey();
        }

        public static bool IsMatch(string s, string p)
        {
            char[] sArray = s.ToCharArray();
            char[] pArray = p.ToCharArray();


            for (int i = 0; i < sArray.Length; i++)
            {
                if (pArray.Length<i)
                {
                    return false;
                }
                
                
                    if (sArray[i] != pArray[i])
                    {
                        if (pArray[i]== '.' && pArray[i + 1]=='*')
                        {
                            return true;
                        }
                        else if (pArray[i]=='*')
                        {
                        return true;
                        }
                        
                    }
                 



                
            }



            return false;
        }



    }
}
