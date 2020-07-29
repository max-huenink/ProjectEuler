using System;
using System.Diagnostics;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Console.WriteLine(Problems.ExecuteProblem(1));
            Console.WriteLine(Problems.ExecuteProblem(2));
            Console.WriteLine(Problems.ExecuteProblem(3));
            sw.Stop();
            Console.WriteLine($"Completed in {sw.ElapsedTicks} ticks, which is {sw.ElapsedMilliseconds} ms");
        }
    }
}
