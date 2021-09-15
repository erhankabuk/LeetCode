using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseOnlyLetters
{
    class Program
    {
        static void Main(string[] args)
        {   /*Given a string s, reverse the string according to the following rules:
            All the characters that are not English letters remain in the same position.
            All the English letters (lowercase or uppercase) should be reversed.
            Return s after reversing it.

            Example 1:
            Input: s = "ab-cd"
            Output: "dc-ba"

            Example 2:
            Input: s = "a-bC-dEf-ghIj"
            Output: "j-Ih-gfE-dCba"

            Example 3:
            Input: s = "Test1ng-Leet=code-Q!"
            Output: "Qedo1ct-eeLg=ntse-T!" 

            Constraints:
            1 <= s.length <= 100
            s consists of characters with ASCII values in the range [33, 122].
            s does not contain '\"' or '\\'.

            Hint : This problem is exactly like reversing a normal string except that there are certain characters that we have to simply skip. That should be easy enough to do if you know how to reverse a string using the two-pointer approach.
            */


            // Output: "Qedo1ct-eeLg=ntse-T!"
            string[] letters = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            // string s1 = "Test1ng-Leet=code-Q!";
            //Console.WriteLine(letters.Contains(s1[4].ToString()));
            //ReverseOnlyLetters();

            ReverseOnlyLetters();
            Console.ReadKey();

        }
        // Stringi taramaya soldan ve sağdan başlayıp Iki adet indeks degiskeninde harflerin indeksleri sırayla al

        private static void ReverseOnlyLetters()
        {
            string[] letters = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

            char[] charLetters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            string s = "Test1ng-Leet=code-Q!";

            string sTemp = String.Copy(s);
            /*  string sTemp = string.Copy(s);
              Console.WriteLine(s);
              List<int> left = new List<int>();
              List<int> right = new List<int>();
              int pivot = s.Length * 2;
              int count = 0;
              for (int i = 0; i < s.Length/2+1; i++)
              {
                  if (charLetters.Contains(s[i]))
                  {
                      left.Add(i);
                  }
              }            
              for (int i = s.Length-1; i >=s.Length/2; i--)
              {
                  if (charLetters.Contains(s[i]))
                  {
                      right.Add(i);
                  }
              }
              foreach (var item in left)
                  Console.Write(item + " ");
              Console.WriteLine();
              foreach (var item in right)
                  Console.Write(item + " ");
              Console.WriteLine();
              if (left.Count < right.Count)
                  count = left.Count;
              else count = right.Count;

              for (int i = 0; i < count; i++)
              {

                  char temp = s[left.IndexOf(left[i])];
                  s = s.Replace(s[left.IndexOf(left[i])], s[right.IndexOf(right[i])]);
                  s = s.Replace(s[right.IndexOf(right[i])], temp);

                  Console.WriteLine(s);
              }
              */


            List<int> left = new List<int>();
            List<int> right = new List<int>();
            int pivot = (s.Length) / 2;
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (charLetters.Contains(s[i]))
                    left.Add(i);
            }
            for (int j = s.Length - 1; j >= 0; j--)
            {
                if (charLetters.Contains(s[j]))
                    right.Add(j);
            }
            foreach (var item in left)
                Console.Write(item + " ");
            Console.WriteLine();
            foreach (var item in right)
                Console.Write(item + " ");
            Console.WriteLine();
            if (left.Count < right.Count)
                count = left.Count/2;
            else count = right.Count/2;

            Console.WriteLine("count"+count);
           // Array.IndexOf(left,5);


            for (int i = 0; i < count; i++)
            {               
                char temp = s[left[i]];
                s = s.Replace(s[left[i]], s[right[i]]);
                s = s.Replace(s[right[i]], temp);
                Console.WriteLine("sağdan"+s);           
            }
            
            for (int i = 0; i <= count+1; i++)
            {
                char temp = sTemp[right[i]];
                s = s.Replace(sTemp[right[i]], sTemp[left[i]]);
                s = s.Replace(sTemp[left[i]], temp);
                Console.WriteLine("soldan" + s);
            }



        }
    }
}
