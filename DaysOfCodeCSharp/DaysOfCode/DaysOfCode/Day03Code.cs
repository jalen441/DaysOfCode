﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class Day03Code
    {
        public int GreenTicket(int a, int b, int c)
        {
            if (a != b && b != c && c != a)
                return 0;
            else if (a == b && b == c)
                return 20;
            else return 10;
        }
    }
}
//Create an integer method called GreenTicket that takes in three integers, "a". "b", and "c"

//You have a green lottery ticket, with ints a, b, and c on it.If the numbers are all different from each other,  the result is 0. 
// If all of the numbers are the same, the result is 20. If two of the numbers are the same, the result is 10.

//greenTicket(1, 2, 3) → 0

//greenTicket(2, 2, 2) → 20

//greenTicket(1, 1, 2) → 10
