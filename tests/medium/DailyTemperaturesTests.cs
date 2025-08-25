using System.Diagnostics;
using core.medium;

namespace tests.medium;

[TestFixture]
public class DailyTemperaturesTests
{
    [Test]
    public void Solve_Example1_ReturnsExpectedOutput()
    {
        var solution = new DailyTemperatures();
        // Arrange
        int[] temperatures = [73, 74, 75, 71, 69, 72, 76, 73];
        int[] expected = [1, 1, 4, 2, 1, 1, 0, 0];

        // Act
        var result = solution.Solve(temperatures);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Solve_Example2_ReturnsExpectedOutput()
    {
        var solution = new DailyTemperatures();
        // Arrange
        int[] temperatures = [30, 40, 50, 60];
        int[] expected = [1, 1, 1, 0];

        // Act
        var result = solution.Solve(temperatures);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Solve_Example3_ReturnsExpectedOutput()
    {
        var solution = new DailyTemperatures();
        // Arrange
        int[] temperatures = [30, 60, 90];
        int[] expected = [1, 1, 0];

        // Act
        var result = solution.Solve(temperatures);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Solve_LargeInput_PerformanceTest()
    {
        var solution = new DailyTemperatures();

        // Arrange: 100,000 temperatures strictly increasing
        int n = 100_000;
        int[] temperatures = [.. Enumerable.Range(1, n)];
        int[] expected = new int[n];

        // For strictly increasing: each element waits exactly 1 day, except the last
        for (int i = 0; i < n - 1; i++)
            expected[i] = 1;
        expected[n - 1] = 0;

        // Act
        Stopwatch sw = Stopwatch.StartNew();
        var result = solution.Solve(temperatures);
        sw.Stop();
        Console.WriteLine(
            $"DailyTemperatures: Time taken for {n} elements using O(n): {sw.ElapsedMilliseconds} ms"
        );

        sw.Restart();
        var bruteForceResult = solution.Solve_BruteForce(temperatures);
        sw.Stop();

        Console.WriteLine(
            $"DailyTemperatures: Time taken for {n} elements using O(n^2): {sw.ElapsedMilliseconds} ms"
        );

        // Assert
        Assert.That(result, Is.EqualTo(bruteForceResult));
        Assert.That(result, Is.EqualTo(expected));
    }
}
