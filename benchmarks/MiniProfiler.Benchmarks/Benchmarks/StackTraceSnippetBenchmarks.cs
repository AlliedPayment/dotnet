using Allied.Core.Profiling.Helpers;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;

namespace Benchmarks.Benchmarks
{
    [ClrJob, CoreJob]
    [Config(typeof(Configs.Full))]
    public class StackTraceSnippetBenchmarks
    {
        private MiniProfilerBenchmarkOptions Options { get; } = new MiniProfilerBenchmarkOptions();

        [Benchmark(Description = "System.Ben Baseline")]
        public void SystemDotBen() { }
        [Benchmark(Description = "StackTraceSnippet.Get()")]
        public string StackTraceSnippetGet() => StackTraceSnippet.Get(Options);
    }
}
