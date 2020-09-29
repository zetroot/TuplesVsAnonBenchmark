using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TuplesVsAnonBenchmark
{
    public class TestClass
    {
        [Params(1000, 10000, 100000, 1000000, 10000000, 100000000)]
        public int N { get; set; }
        
        [Benchmark]
        public List<int> AnonTransformation()
        {
            return Enumerable.Range(0, N).Select(x => new { a = x, b = x / 2 }).Select(x => x.a + x.b).ToList();
        }

        [Benchmark]
        public List<int> ValueTuplesTransformation()
        {
            return Enumerable.Range(0, N).Select(x => (x, x / 2)).Select(x => x.x + x.Item2).ToList();
        }

        [Benchmark]
        public List<int> NamedValueTuplesTransformation()
        {
            return Enumerable.Range(0, N).Select(x => (A: x, B: x / 2)).Select(x => x.A + x.B).ToList();
        }

        [Benchmark]
        public List<int> TuplesTransformation()
        {
            return Enumerable.Range(0, N).Select(x => new Tuple<int, int>(x, x/2)).Select(x => x.Item1 + x.Item2).ToList();
        }
    }
}
