using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Interview__Prepration_Problem_and_Solution.Array_and_String
{
    public class ArrayAndString
    {
        public int RemoveDuplicatesFromAnArrayUsingAnotherArray(int[] array)
        {
            var uniqueArray = new List<int>();

            foreach (var number in array)
            {
                if (!uniqueArray.Contains(number))
                {
                    uniqueArray.Add(number);
                }
            }
            return uniqueArray.Count;
        }

        public int RemoveDuplicatesFromAnArrayUsingAnotherArrayRaw(int[] nums)
        {
            if (nums.Length != 0)
            {
                int[] uniqueArray = new int[nums.Length];
                int uniqueArrayIndex = 0;


                uniqueArray[uniqueArrayIndex++] = nums[0];

                var length = nums.Length;
                for (int i = 1; i < length; i++)
                {
                    if (nums[i] != nums[i - 1])
                    {
                        uniqueArray[uniqueArrayIndex++] = nums[i];
                    }
                }
                return uniqueArrayIndex;
            }
            else
            {
                return 0;
            }
        }
        
        public List<int> SpiralOrderMatrix(int[,] matrix,int col,int row) {
            int direction = 0, left = 0, top = 0;
            int right = row-1;
            int bottom = col-1;
            var linearArray = new List<int>();
            while (true)
            {
                if (direction == 0)
                {
                    //left to right
                    for (int i = left; i < right + 1; i++)
                    {
                        linearArray.Add(matrix[top, i]);
                    }
                    top++;
                }
                else if (direction == 1)
                {
                    //top to bottom
                    for (int i = top; i < bottom + 1; i++)
                    {
                        linearArray.Add(matrix[i, right]);
                    }
                    right--;
                }
                else if (direction == 2)
                {
                    //right to left
                    for (int i = right; i > left - 1; i--)
                    {
                        linearArray.Add(matrix[bottom, i]);
                    }
                    bottom--;
                }
                else if (direction == 3)
                {
                    //bottom to up
                    for (int i = bottom; i > top - 1; i--)
                    {
                        linearArray.Add(matrix[i, left]);
                    }
                    left++;
                }

                direction = (direction + 1) % 4;
                
                if (linearArray.Count == row * col){ 
                    //linearArray.Add(matrix[left, top]);
                    break;
                };
            }

            return linearArray;

        }
    }
}
