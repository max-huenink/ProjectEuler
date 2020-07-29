using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    public class Problems
    {
        private static Func<int>[] problems = new Func<int>[100];
        static Problems()
        {
            #region Problem1
            problems[0] = () =>
            {
                int[] nums = new int[997];
                for (int i = 3; i < 1000; i++)
                {
                    nums[i - 3] = i;
                }
                return nums.Where(n => n % 3 == 0 || n % 5 == 0).Sum();
            };
            #endregion

            #region Problem 2
            problems[1] = () =>
            {
                Queue<int> fib = new Queue<int>(new int[] { 1, 2 });
                int sum = 2;
                int first = fib.Dequeue();
                while (first < 4000000)
                {
                    int nextNum = first + fib.Peek();
                    if (nextNum % 2 == 0)
                        sum += nextNum;
                    fib.Enqueue(nextNum);
                    first = fib.Dequeue();
                }
                return sum;
            };
            #endregion

            #region Problem 3
            problems[2] = () => -1;
            #endregion
        }

        /// <summary>
        /// Executes the problem number
        /// </summary>
        /// <param name="number">A non zero index for the problem number</param>
        /// <returns>The result</returns>
        public static int ExecuteProblem(int number) =>
            problems[number - 1]();

    }
}
