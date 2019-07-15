using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class Day08Code
    {
        public bool No23(int[] nums)
        {
            if (nums.Contains(2) || nums.Contains(3))
                return false;
            else return true;
        }
    }
    /*  Create a method of type boolean called No23 that takes in an integer array “nums”. 
        Given an int array length 2, return true if it does not contain a 2 or 3.

        no23([4, 5]) → true

        no23([4, 2]) → false

        no23([3, 5]) → false
    */
}
