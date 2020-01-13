using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    public class Problem2 : ProblemX
    {
        public Problem2()
        {
            Queue<int> fib = new Queue<int>(new int[] { 1, 2 });
            int sum = 2;
            int first = fib.Dequeue();
            while(first < 4000000)
            {
                int nextNum = first + fib.Peek();
                if (nextNum % 2 == 0)
                    sum += nextNum;
                fib.Enqueue(nextNum);
                first = fib.Dequeue();
            }
            Answer = sum;
        }
    }
}
