namespace Benchmark
{
    using BenchmarkDotNet.Running;

    internal class Program
    {
        static void Main()
        {
            BenchmarkRunner.Run<FindVsFirstOrDefault>();
        }
    }
}
