using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    internal class RandomNumbersToSort
    {
        public static int[] RandomNumbers_1to10_Unique
        { 
            get
            {
                return new int[] { 2, 7, 3, 5, 4, 9, 10, 6, 8, 1 };
            } 
        }

        public static int[] ExpectedRandomNumers_1To10_Unique
        {
            get
            {
                return new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            }
        }
    }
}
