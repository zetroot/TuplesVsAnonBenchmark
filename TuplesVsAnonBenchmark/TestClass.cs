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
        public int[] AnonTransformation()
        {
            var srcArr = Enumerable.Range(0, N).ToArray();
            var anonArr = srcArr.Select(x => new { a = x, b = x / 2 }).ToArray();
            return anonArr.Select(x => x.a + x.b).ToArray();
        }

        [Benchmark]
        public int[] ValueTuplesTransformation()
        {
            var srcArr = Enumerable.Range(0, N).ToArray();
            var anonArr = srcArr.Select(x => (x, x / 2)).ToArray();
            return anonArr.Select(x => x.x + x.Item2).ToArray();
        }

        [Benchmark]
        public int[] TuplesTransformation()
        {
            var srcArr = Enumerable.Range(0, N).ToArray();
            var anonArr = srcArr.Select(x => new Tuple<int, int>(x, x / 2)).ToArray();
            return anonArr.Select(x => x.Item1 + x.Item2).ToArray();            
        }
    }
}
