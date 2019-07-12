using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class Day11Code
    {
        public int[] MakeMiddle(int[] nums)
        {
            int[] result = new int[2];

            int mid = nums.Length / 2;
            result[0] = nums[mid - 1];
            result[1] = nums[mid];

            return result;
        }
    }
    //Create an integer array method called MakeMiddle that takes in an integer array “nums”. 
    //Given an array of ints of even length, return a new array length 2 containing the middle two elements from the original array.
    //The original array will be length 2 or more.

    //makeMiddle([1, 2, 3, 4]) → [2, 3]

    //makeMiddle([7, 1, 2, 3, 4, 9]) → [2, 3]

    //makeMiddle([1, 2]) → [1, 2]
}
