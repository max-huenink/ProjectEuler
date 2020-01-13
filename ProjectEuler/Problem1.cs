using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProjectEuler
{
    class Problem1 : ProblemX
    {
        public Problem1()
        {
            int[] nums = new int[997];
            for (int i = 3; i < 1000; i++)
            {
                nums[i - 3] = i;
            }
            Answer = nums.Where(n => n % 3 == 0 || n % 5 == 0).Sum();
        }
    }
}
