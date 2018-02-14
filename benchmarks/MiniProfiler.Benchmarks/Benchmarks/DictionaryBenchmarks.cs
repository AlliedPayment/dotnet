using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Allied.Core.Profiling;

namespace Benchmarks.Benchmarks
{
    [ClrJob, CoreJob]
    [Config(typeof(Configs.Memory))]
    public class DictionaryBenchmarks
    {
        [Benchmark(Description = "new Dictionary<string, CustomTiming>")]
        public Dictionary<string, CustomTiming> DictionaryCreate() =>
            new Dictionary<string, CustomTiming>();

        [Benchmark(Description = "new ConcurrentDictionary<string, CustomTiming>")]
        public ConcurrentDictionary<string, CustomTiming> ConcurrentDictionaryCreate() =>
            new ConcurrentDictionary<string, CustomTiming>();
    }
}
