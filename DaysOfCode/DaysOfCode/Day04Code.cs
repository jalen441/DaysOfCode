using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfCode
{
    public class Day04Code
    {
        public int Start1(int[] a, int[] b)
        {
            int count = 0;
            if (a.Length > 0 && a[0] == 1)
                count++;
            if (b.Length > 0 && b[0] == 1)
                count++;
            return count;
        }
    }
    /* Create an integer method called Start1 that takes in two integer arrays "a" and "b". 
     * Start with 2 int arrays, a and b, of any length.
     * Return how many of the arrays have 1 as their first element.

        start1([1, 2, 3], [1, 3]) → 2

        start1([7, 2, 3], [1]) → 1

        start1([1, 2], ) → 1
    */
}
