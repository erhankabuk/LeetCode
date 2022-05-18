using System;
using System.Collections;
using System.Collections.Generic;

namespace ValidParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
             * 
            An input string is valid if:

            Open brackets must be closed by the same type of brackets.
            Open brackets must be closed in the correct order. 

            Example 1:

            Input: s = "()"
            Output: true
            Example 2:

            Input: s = "()[]{}"
            Output: true
            Example 3:

            Input: s = "(]"
            Output: false
            */
            //string input = "{[]}()";
            string input = "{[()]()}";
            Console.WriteLine(IsValid(input));
        }
        public static bool IsValid(string input)
        {
            Stack<char> sign = new Stack<char>();
            char[] arr = input.ToCharArray();
            foreach (var item in arr)
                if (item == '(')
                    sign.Push(')');
                else if (item == '[')
                    sign.Push(']');
                else if (item == '{')
                    sign.Push('}');
                else if (sign.Count == 0 || sign.Pop() != item)
                    return false;

            return sign.Count == 0;
        }
    }
}
