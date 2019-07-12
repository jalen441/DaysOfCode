﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class Day07Code
    {
        public bool NoTuples(int[] nums)
        {
            bool noTuples = true;

            if (nums.Length > 2)
                for (int i = 0; i < nums.Length - 2; i++)
                    if (nums[i] == nums[i + 1] && nums[i] == nums[i + 2])
                    {
                        noTuples = false;
                        break;
                    }

            return noTuples;
        }
    }
    /*
     Create a boolean method called NoTuples that takes in an integer array “nums”.  
     Given an array of ints, we'll say that a triple is a value appearing 3 times in a row in the array. 
     Return true if the array does not contain any triples.

     noTriples([1, 1, 2, 2, 1]) → true
     
     noTriples([1, 1, 2, 2, 2, 1]) → false
     
     noTriples([1, 1, 1, 2, 2, 2, 1]) → false
    */
}
