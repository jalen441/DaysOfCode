using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class Day09Code
    {
        public int[] PlusTwo(int[] a, int[] b)
        {
            return a.Concat(b).ToArray();
        }
    }
    /*Create an integer array method called PlusTow that takes in two integer arrays, “a” and “b”. 
      Given 2 int arrays, each length 2, return a new array length 4 containing all their elements.

      plusTwo([1, 2], [3, 4]) → [1, 2, 3, 4]

      plusTwo([4, 4], [2, 2]) → [4, 4, 2, 2]

      plusTwo([9, 2], [3, 4]) → [9, 2, 3, 4]
    */
}
