using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    class Program
    {

        static void Main(string[] args)
        {
            /*Given a string s representing a valid expression, implement a basic calculator to evaluate it, and return the result of the evaluation.
              Note: You are not allowed to use any built-in function which evaluates strings as mathematical expressions, such as eval().

              Example 1:

              Input: s = "1 + 1"
              Output: 2
              Example 2:

              Input: s = " 2-1 + 2 "
              Output: 3
              Example 3:

              Input: s = "(1+(4+5+2)-3)+(6+8)"
              Output: 23 

              Constraints:

              1 <= s.length <= 3 * 105
              s consists of digits, '+', '-', '(', ')', and ' '.
              s represents a valid expression.
              '+' is not used as a unary operation.
              '-' could be used as a unary operation but it has to be inside parentheses.
              There will be no two consecutive operators in the input.
              Every number and running calculation will fit in a signed 32-bit integer.
              */



            /*
             önce stringi index index ayır 
            her indexi dolaş () varsa içine ayrı bir liste oluşturup işlem yap,
            hepsini toplayacak*/

            //Output: 23

            string s = "(1+(4+5+2) -3)+ (6+8)";

            yeniToplama(s);
            Console.ReadKey();
        }

        private static void yeniToplama(string s)
        {
            int calc = 0;
            string onValue;
            for (int i = 0; i < s.Length; i++)
            {
                onValue = s.Substring(i, 1);

                if (onValue.Equals("(") || onValue.Equals(")") || onValue.Equals(" "))
                    continue;
                else if (onValue.Equals("+"))
                {

                    if (s.Substring(i + 1, 1).Equals("(") || s.Substring(i + 1, 1).Equals(")") || s.Substring(i + 1, 1).Equals(" "))
                        continue;

                    else if (s.Substring(i + 1, 1).Equals("-"))
                    {
                        calc -= Convert.ToInt32(s.Substring(i + 1, 1));
                        i++;
                    }
                    else
                    {
                        calc += Convert.ToInt32(s.Substring(i + 1, 1));
                        i++;
                    }

                }
                else if (onValue.Equals("-"))
                {
                    if (s.Substring(i + 1, 1).Equals("(") || s.Substring(i + 1, 1).Equals(")") || s.Substring(i + 1, 1).Equals(" "))
                        continue;
                    else if (s.Substring(i + 1, 1).Equals("+"))
                    {
                        calc += Convert.ToInt32(s.Substring(i + 1, 1));
                        i++;
                    }
                    else
                    {
                        calc -= Convert.ToInt32(s.Substring(i + 1, 1));
                        i++;
                    }
                }
                else
                    calc += Convert.ToInt32(s.Substring(i, 1));

                Console.WriteLine(calc);
            }
        }

    }
}
