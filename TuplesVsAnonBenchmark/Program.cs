using BenchmarkDotNet.Running;
using System;

namespace TuplesVsAnonBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<TestClass>();
        }
    }
}
