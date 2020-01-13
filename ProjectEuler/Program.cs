using System;
using System.Diagnostics;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Pow(2, 40) - 1);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Console.WriteLine(new Problem2().Execute());
            sw.Stop();
            Console.WriteLine($"Completed in {sw.ElapsedTicks} ticks, which is {sw.ElapsedMilliseconds} ms");
        }
    }
}
