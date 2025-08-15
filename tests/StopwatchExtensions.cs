using System.Diagnostics;

namespace tests;

public static class StopwatchExtensions
{
    public static double GetElapsedNanoseconds(this Stopwatch sw)
    {
        return sw.ElapsedTicks * (1_000_000_000.0 / Stopwatch.Frequency);
    }
}
