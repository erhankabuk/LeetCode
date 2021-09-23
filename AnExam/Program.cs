using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnExam
{
    class Program
    {
        static void Main(string[] args)
        {//FindOriginalArrayden devam et
            /*
            string text = "ReverseText";
            ReverseText(text);
            Console.WriteLine(ReverseText(text));
            */

            /*
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            ShuffleAnyArray(arr);
            */

            // Fibonacci(1000);

            //Factorial(5);

            //Console.WriteLine( FactorialRecursive(5)) ;

            //Console.WriteLine(  string.Join(", ", Digits(2534))); 
            
            /*
            int[] arr1 = new int[] {1,2,3,4 };
            int[] arr2 = new int[] { 1, 2, 3, 4 };
            MergeArrays(arr1, arr2);
            */

            //Console.WriteLine(string.Join(", ", Dice()));
                        
            LivedDay(2000, 1, 1);
            
            Console.ReadKey();
        }

        private static string ReverseText(string text)
        {
            char[] reverseArray = text.ToArray();
            Array.Reverse(reverseArray);
            return new string(reverseArray);
        }

        private static void ShuffleAnyArray<T>(T[] arr)
        {
            Random random = new Random();
            T temp;
            int selectedIndex;
            for (int i = 0; i < arr.Length; i++)
            {
                selectedIndex = random.Next(i, arr.Length);
                temp = arr[i];
                arr[i] = arr[selectedIndex];
                arr[selectedIndex] = temp;
            }
        }

        public static int[] Fibonacci(int fibNum)
        {
            List<int> fib = new List<int>();
            int sum = 0, val1 = 0, val2 = 1;
            while (sum < fibNum)
            {
                sum = val1 + val2;
                val1 = val2;
                val2 = sum;
                fib.Add(sum);
            }
            int[] fibArray = fib.ToArray();
            return fibArray;
        }

        public static int Factorial(int n)
        {
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial = i * factorial;
            }
            return factorial;
        }

        static int FactorialRecursive(int n)
        {
            if (n < 2) return n;
            else return n * FactorialRecursive(n - 1);
        }

        static int[] Digits(int num)
        {
            List<int> arr = new List<int>();
            int digit;
            while (num > 0)
            {
                digit = num % 10;                
                arr.Add(digit);
                num = num / 10;
            }
            int[] array = arr.ToArray();
            Array.Reverse(array);
            return array;
        }

        static int[] MergeArrays(int[] arr1, int[] arr2)
        {
            List<int> mergedList = new List<int>();
            foreach (var item in arr1)
            {
                mergedList.Add(item);
            }
            foreach (var item in arr2)
            {
                mergedList.Add(item);
            }
            int[] mergedArray = mergedList.ToArray();
            return mergedArray;
        }
        static string[] Dice()
        {
            string[] dices = new string[36];

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    string dice = $"{i + 1}-{j + 1}";
                    int indexOfDice = i * 6 + j;
                    dices[indexOfDice] = dice;
                }
            }
            return dices;
        }

        static int LivedDay(int birthYear, int birthMonth, int birthDay)
        {
            DateTime birthDate = new DateTime(birthYear, birthMonth, birthDay);
            DateTime currentDate = DateTime.Now;
            int LivedDay = Convert.ToInt32((currentDate - birthDate).TotalDays);
            Console.WriteLine(LivedDay);
            return LivedDay;
        }

    }
}
