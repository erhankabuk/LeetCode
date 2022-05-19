using System;
using System.Collections.Generic;
using System.Text;

namespace IntegerToRoman
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
            Given an integer, convert it to a roman numeral.

 

            Example 1:

            Input: num = 3
            Output: "III"
            Explanation: 3 is represented as 3 ones.
            Example 2:

            Input: num = 58
            Output: "LVIII"
            Explanation: L = 50, V = 5, III = 3.
            Example 3:

            Input: num = 1994
            Output: "MCMXCIV"
            Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
            */
            Console.WriteLine(GetIntegerToRoman(700));
        }

        static string GetIntegerToRoman(int num)
        {
            Stack<int> stack = new Stack<int>();

            int temp, len, digit = 0;

            string roman = "";
            while (num > 0)
            {
                temp = num % 10;
                num = num / 10;
                stack.Push(temp);
                digit++;
            }
            len = stack.Count;
            for (int i = 0; i < len; i++)
            {
                temp = stack.Peek();
                string s = GetLetter(temp, digit);
                roman = roman + s;
                stack.Pop();
                digit--;
            }

            return roman;
        }

        private static string GetLetter(int temp, int digit)
        {
            string roman = "";
            if (temp == 0)
            {
                return "";
            }

            if (temp > 0 && temp < 4)
            {
                if (digit == 1)
                {
                    for (int i = 0; i < temp; i++)
                    {
                        roman = roman + "I";
                    }
                    return roman;
                }
                else if (digit == 2)
                {
                    for (int i = 0; i < temp; i++)
                    {
                        roman = roman + "X";
                    }
                    return roman;
                }
                else if (digit == 3)
                {
                    for (int i = 0; i < temp; i++)
                    {
                        roman = roman + "C";
                    }
                    return roman;
                }
                else if (digit == 4)
                {
                    for (int i = 0; i < temp; i++)
                    {
                        roman = roman + "M";
                    }
                    return roman;
                }
            }
            else if (temp == 4)
            {
                if (digit == 1)
                {
                    return string.Concat(roman, "IV");
                }
                else if (digit == 2)
                {
                    return string.Concat(roman, "XL");
                }
                else if (digit == 3)
                {
                    return string.Concat(roman, "CD");
                }
            }
            else if (temp == 5)
            {
                if (digit == 1)
                {
                    return string.Concat(roman, "V");
                }
                else if (digit == 2)
                {
                    return string.Concat(roman, "L");

                }
                else if (digit == 3)
                {
                    return string.Concat(roman, "D");
                }
            }
            else if (temp > 5 && temp < 9)
            {
                if (digit == 1)
                {
                    roman = "V";
                    for (int i = 0; i < temp % 5; i++)
                    {
                        roman = roman + "I";
                    }
                    return roman;
                }
                else if (digit == 2)
                {
                    roman = roman + "L";
                    for (int i = 0; i < temp % 5; i++)
                    {
                        roman = roman + "X";
                    }
                    return roman;
                }
                else if (digit == 3)
                {
                    roman = roman + "D";
                    for (int i = 0; i < temp % 5; i++)
                    {
                        roman = roman + "C";
                    }
                    return roman;
                }
            }
            else if (temp == 9)
            {
                if (digit == 1)
                {
                    return string.Concat(roman, "IX");

                }
                else if (digit == 2)
                {
                    return string.Concat(roman, "XC");

                }
                else if (digit == 3)
                {
                    return string.Concat(roman, "CM");
                }
            }
            return "";
        }
    }
}