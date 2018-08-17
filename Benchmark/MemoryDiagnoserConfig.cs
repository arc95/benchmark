[assembly: BenchmarkDotNet.Attributes.Config(typeof(Benchmark.MemoryDiagnoserConfig))]
namespace Benchmark
{
    using BenchmarkDotNet.Configs;
    using BenchmarkDotNet.Diagnosers;

    public class MemoryDiagnoserConfig : ManualConfig
    {
        public MemoryDiagnoserConfig()
        {
            this.Add(MemoryDiagnoser.Default);
        }
    }
}