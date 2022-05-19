﻿using System;
using System.Linq;

namespace RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

            Symbol       Value
            I             1
            V             5
            X             10
            L             50
            C             100
            D             500
            M             1000
            For example, 2 is written as II in Roman numeral, just two one's added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

            Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

            I can be placed before V (5) and X (10) to make 4 and 9. 
            X can be placed before L (50) and C (100) to make 40 and 90. 
            C can be placed before D (500) and M (1000) to make 400 and 900.
            Given a roman numeral, convert it to an integer.

 

            Example 1:

            Input: s = "III"
            Output: 3
            Explanation: III = 3.
            Example 2:

            Input: s = "LVIII"
            Output: 58
            Explanation: L = 50, V= 5, III = 3.
            Example 3:

            Input: s = "MCMXCIV"
            Output: 1994
            Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
            */
            //string roman = "III";//3
            //string roman = "LVIII";//58
           string roman = "MCMXCIV";//1994
            Console.WriteLine(GetRomanToInteger(roman));
        }
        static int GetRomanToInteger(string input)
        {
            int result = 0;
            var digits = input.ToCharArray().Select(x => x.ToString()).ToArray();
            int len = digits.Length;
            for (int i = 0; i < len;)
            {

                if (digits[i] == "I")
                {
                    if (i == len - 1) { result += 1; }
                    else if (i<len-1)
                    {
                        if (digits[i + 1] == "V")
                        {
                            result += 4;
                            i++;
                        }
                        else if (digits[i + 1] == "X")
                        {
                            result += 9;
                            i++;
                        }
                        else { result += 1; }

                    }
                }
                else if (digits[i] == "V") { result += 5; }
                else if (digits[i] == "X")
                {
                    if (i == len - 1) { result += 10; }
                    else if (i < len - 1)
                    {

                        if (digits[i + 1] == "L")
                    {
                        result += 40;
                        i++;
                    }
                    else if (digits[i + 1] == "C")
                    {
                        result += 90;
                        i++;
                    }
                    else { result += 10; }
                    }

                }
                else if (digits[i] == "L") { result += 50; }
                else if (digits[i] == "C")
                {
                    if (i == len - 1) { result += 100; }
                    else if (i < len - 1)
                    {
                        if (digits[i + 1] == "D")
                        {
                            result += 400;
                            i++;
                        }
                        else if (digits[i + 1] == "M")
                        {
                            result += 900;
                            i++;
                        }
                        else { result += 100; }
                    }
                }
                else if (digits[i] == "D") { result += 500; }
                else if (digits[i] == "M") { result += 1000; }

                i++;
            }
            return result;
        }
    }
}