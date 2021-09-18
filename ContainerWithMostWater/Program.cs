using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerWithMostWater
{
    class Program
    {
        static void Main(string[] args)
        {/*
            Given n non-negative integers a1, a2, ..., an , where each represents a point at coordinate (i, ai). n vertical lines are drawn such that the two endpoints of the line i is at (i, ai) and (i, 0). Find two lines, which, together with the x-axis forms a container, such that the container contains the most water.
            Notice that you may not slant the container.

            Example 1:
            Input: height = [1,8,6,2,5,4,8,3,7]
            Output: 49
            Explanation: The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7]. In this case, the max area of water (blue section) the container can contain is 49.

            Example 2:
            Input: height = [1,1]
            Output: 1

            Example 3:
            Input: height = [4,3,2,1,4]
            Output: 16

            Example 4:
            Input: height = [1,2,1]
            Output: 2
          */
            int[] height = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            //int[] height = new int[] { 1, 1 };
            //int[] height = new int[] { 4, 3, 2, 1, 4 };
            //int[] height = new int[] { 1, 2, 1 };

            Console.WriteLine(MaxArea(height));
            Console.ReadKey();
        }
        public static int MaxArea(int[] height)
        {
            int container = 0;
            int xAxis, yAxis, volume;
            for (int i = 0; i < height.Length; i++)
            {
                for (int j = i + 1; j < height.Length; j++)
                {
                    xAxis = j - i;
                    yAxis = height[i] >= height[j] ? height[j] : height[i];
                    volume = xAxis * yAxis;
                    if (volume > container)
                        container = volume;

                    /*
                    //solution 2
                    xAxis = j - i;                    
                    if (height[i] >= height[j])
                    {
                        volume = xAxis * height[j];
                        if (volume > container)
                            container = volume;
                    }
                    else
                    {
                        volume = xAxis * height[i];
                        if (volume > container)
                            container = volume;
                    }    
                    
                    //solution 3
                    int max = 0;
                    int left = 0;
                    int right = height.Length - 1;

                    while (left < right)
                    {
                        var area = Math.Min(height[right], height[left]) * (right - left);
                        max = Math.Max(max, area);
                        if (height[left] < height[right])
                            left++;
                        else
                            right--;
                    }
                    return max;
                    */
                }
            }
            return container;
        }
    }
}
