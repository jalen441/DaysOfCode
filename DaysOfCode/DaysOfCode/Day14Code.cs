using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DaysOfCode
{
    public class Day14Code
    {
        public bool LessBy10(int a, int b, int c)
        {
            bool isLessBy10 = false;

            if (Math.Abs(a - b) >= 10 || Math.Abs(a - c) >= 10 || Math.Abs(b - c) >= 10)
            {
                isLessBy10 = true;
            }

            return isLessBy10;
        }
    }
    //Create a boolean method called LessBy10 that take in three integers, “a, “b”, and “c”. 
    //Given three ints, a b c, return true if one of them is 10 or more different than one of the others.

    //lessBy10(1, 7, 11) → true

    //lessBy10(1, 7, 10) → false

    //lessBy10(11, 1, 7) → true
}
