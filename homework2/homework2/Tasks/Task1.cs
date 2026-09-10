using System;
using System.Collections.Generic;
using System.Text;

namespace homework2.Tasks
{
    public class Task1
    {
        public static void Run(int[] array)
        {
            if (array == null || array.Length <= 1)
                return;

            int left = 0; 
            int right = array.Length - 1;

            while (left < right)
            {
                int temp = array[left];
                array[left] = array[right];
                array[right] = temp;

                left++;
                right--;
            }
        }
    }
}
