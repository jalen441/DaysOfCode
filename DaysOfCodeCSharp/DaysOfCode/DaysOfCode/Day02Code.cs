using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class Day02Code
    {
        public bool Has12(int[] nums)
        {
            bool has12 = false;
            for(int i = 0; i < nums.Length - 1; i++)
            {
                if(nums[i] == 1)
                {
                    if(String.Join("", nums.Select(p => p.ToString()).ToArray(), i, nums.Length - i).Contains("2"))
                        has12 = true;
                }
            }

            return has12;
        }
       
    }
}
/*
    Create a boolean method called Has12 that takes in an integer array "nums". 
    Given an array of ints, return true if there is a 1 in the array with a 2 somewhere later in the array.

    For example:

    has12([1, 3, 2]) → true

    has12([3, 1, 2]) → true

    has12([3, 1, 4, 5, 2]) → true

    (There are many possible solutions. 
    Here is a challenge -  can you do this by looping through the array only once?) 
 */
