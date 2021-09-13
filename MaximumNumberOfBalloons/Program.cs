using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumberOfBalloons
{
    class Program
    {
        static void Main(string[] args)
        { /* Given a string text, you want to use the characters of text to form as many instances of the word "balloon"   as possible.
            You can use each character in text at most once. Return the maximum number of instances that can be formed.
            Example 1:Input: text = "nlaebolko"
            Output: 1
            Example 2:Input: text = "leetcode"
            Output: 0          
          */
            string text = "obbbbooooolllllllaaaannnnnknhamömönbllasdfsofsfoooooooooosnosfsfsfbal";
            MaximumNumberOfBalloons(text);
            Console.ReadKey();
        }


        private static void MaximumNumberOfBalloons(string text)
        {
            int b = 0, a = 0, l = 0, o = 0, n = 0, balloon = 0;
            bool baloonLoop = true;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'b')
                    b++;
                else if (text[i] == 'a')
                    a++;
                else if (text[i] == 'l')
                    l++;
                else if (text[i] == 'o')
                    o++;
                else if (text[i] == 'n')
                    n++;
            }
            Console.WriteLine("b " + b + " a " + a + " l " + l + " o " + o + " n " + n);
            while (baloonLoop)
            {
                if (b > 0 && a > 0 && l > 1 && o > 1 && n > 0)
                {
                    balloon++;
                    b -= 1;
                    a -= 1;
                    l -= 2;
                    o -= 2;
                    n -= 1;
                }
                else baloonLoop = false;    
            }
            Console.WriteLine("Output : "+balloon);          
            // return balloon;            
        }


    }
}
