using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class Day10Code
    {
        public bool More14(int[] nums)
        {
            bool more14 = false;
            int count1 = 0;
            int count4 = 0;

            foreach(int num in nums)
            {
                if (num == 1)
                    count1++;
                if (num == 4)
                    count4++;
            }

            if (count1 > count4)
                more14 = true;

            return more14;
        }
    }

    //Create a boolean method called More14 that takes in an array of type integer “nums”. 
    //Given an array of ints, return true if the number of 1's is greater than the number of 4's

    //more14([1, 4, 1]) → true

    //more14([1, 4, 1, 4]) → false

    //more14([1, 1]) → true
}
