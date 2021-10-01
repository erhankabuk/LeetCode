using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.
                Assume the environment does not allow you to store 64-bit integers (signed or unsigned).

                Example 1:
                Input: x = 123
                Output: 321

                Example 2:
                Input: x = -123
                Output: -321

                Example 3:
                Input: x = 120
                Output: 21

                Example 4:
                Input: x = 0
                Output: 0
            */

            //int x = 123;
            int x = -123;
            //int x = 120;
            //int x = 0;

            Console.WriteLine(Reverse(x));
            Console.ReadKey();
        }

        private static int Reverse(int x)
        {
            int reverseInt = 0;
            int reversed = 0;
            while (x != 0)
            {
                int digit = x % 10;
                reversed = reverseInt * 10 + digit;
                if ((reversed - digit) / 10 != reverseInt)
                    return 0;
                reverseInt = reversed;
                x = x / 10;
            }
            return reversed;
        }
    }
}
