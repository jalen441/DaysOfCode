using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class Day01Code
    {
        public int[] SwapEnds(int[] nums)
        {
            int temp = nums[0];
            nums[0] = nums[nums.Length - 1];
            nums[nums.Length - 1] = temp;
            return nums;
        }
    }
    /*
     
        Days of Code
        Day 1: SwapEnds
        Create an integer array method called SwapEnds that takes in an integer array "nums". 
        Given an array of ints, swap the first and last elements in the array. Return the modified array. 
        The array length will be at least 1.

        For example:

        swapEnds([1, 2, 3, 4]) → [4, 2, 3, 1]

        swapEnds([1, 2, 3]) → [3, 2, 1]

        swapEnds([8, 6, 7, 9, 5]) → [5, 6, 7, 9, 8]

     */
}
