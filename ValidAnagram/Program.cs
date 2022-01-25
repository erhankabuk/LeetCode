using System;
using System.Collections.Generic;

namespace ValidAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Given two strings s and t, return true if t is an anagram of s, and false otherwise. 
            An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original     letters    exactly once.          
             
            Example 1:            
            Input: s = "anagram", t = "nagaram"
            Output: true

            Example 2:            
            Input: s = "rat", t = "car"
            Output: false

            */
            string s = "anagram";
            string t = "nagaram";
            Console.WriteLine(IsAnagram(s, t));
            Console.ReadKey();
        }


        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            List<string> list = new List<string>();

            for (int i = 0; i < t.Length; i++) list.Add(t.Substring(i, 1));
            
            for (int i = 0; i < t.Length; i++)
            {
                if (!list.Contains(s.Substring(i, 1)))return false;
                
                list.Remove(s.Substring(i, 1));
            }

            if (list.Count == 0) return true;

            return false;

        }
    }
}
