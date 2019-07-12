using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class Day13Code
    {
        public int[] MakeEnds(int[] nums)
        {
            return new int[] { nums[0], nums[nums.Length - 1] };
        }
    }
    //Create an integer array method called MakeEnds that takes in an integer array “nums”. 
    //Given an array of ints, return a new array length 2 containing the first and last elements from the original array.
    //The original array will be length 1 or more.

    //makeEnds([1, 2, 3]) → [1, 3]

    //makeEnds([1, 2, 3, 4]) → [1, 4]

    //makeEnds([7, 4, 6, 2]) → [7, 2]
}
