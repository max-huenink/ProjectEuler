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
                int sum = 0;
                for (int i = 3; i < 1000; i++)
                {
                    if (i % 3 == 0 || i % 5 == 0)
                        sum += i;
                }
                return sum;
            };
            #endregion

            #region Problem 2
            problems[1] = () =>
            {
                int a = 1;
                int b = 2;
                int sum = 2;
                while (a < 4000000)
                {
                    int next = a + b;
                    if (next % 2 == 0)
                        sum += next;
                    a = b;
                    b = next;
                }
                return sum;
            };
            #endregion

            #region Problem 3
            // Prime factorization of 13195 is 5, 7, 13, 29
            // Prime factorization of 600851475143
            // Find largest prime factor
            // Divide by lowest prime, if remainder is zero divide result by next prime, repeat remainder step.
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
