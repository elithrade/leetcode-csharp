using System.Diagnostics;

namespace tests;

public static class StopwatchExtensions
{
    public static double GetElapsedNanoseconds(this Stopwatch sw)
    {
        return sw.ElapsedTicks * (1_000_000_000.0 / Stopwatch.Frequency);
    }

    public static string GetElapsedNanosecondsFormatted(this Stopwatch sw)
    {
        var ns = GetElapsedNanoseconds(sw);
        return string.Format("{0:N0} ns", ns);
    }
}
