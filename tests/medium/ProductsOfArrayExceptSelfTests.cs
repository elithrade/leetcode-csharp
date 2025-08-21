using System.Diagnostics;
using core.medium;

namespace tests.medium;

[TestFixture]
public class ProductsOfArrayExceptSelfTests
{
    private ProductsOfArrayExceptSelf _solution;

    [SetUp]
    public void Setup()
    {
        _solution = new ProductsOfArrayExceptSelf();
    }

    [Test]
    public void Solve_BasicPositiveNumbers()
    {
        var nums = new[] { 1, 2, 3, 4 };
        var expected = new[] { 24, 12, 8, 6 };

        var result = _solution.Solve(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Solve_ContainsZeroAndNegatives()
    {
        var nums = new[] { -1, 1, 0, -3, 3 };
        var expected = new[] { 0, 0, 9, 0, 0 };

        var result = _solution.Solve(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Solve_SingleElement()
    {
        var nums = new[] { 5 };
        var expected = new[] { 1 };

        var result = _solution.Solve(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Solve_TwoElements()
    {
        var nums = new[] { 2, 3 };
        var expected = new[] { 3, 2 };

        var result = _solution.Solve(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Solve_AllOnes()
    {
        var nums = new[] { 1, 1, 1, 1 };
        var expected = new[] { 1, 1, 1, 1 };

        var result = _solution.Solve(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Solve_AllNegatives()
    {
        var nums = new[] { -1, -2, -3, -4 };
        var expected = new[] { -24, -12, -8, -6 };

        var result = _solution.Solve(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Solve_TwoZeros()
    {
        var nums = new[] { 1, 0, 3, 0 };
        var expected = new[] { 0, 0, 0, 0 };

        var result = _solution.Solve(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Solve_LargeNumbers()
    {
        var nums = new[] { 1000, 2000, 3000 };
        var expected = new[] { 6000000, 3000000, 2000000 };

        var result = _solution.Solve(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Solve_LargeArray()
    {
        // Arrange
        int n = 1000;
        var nums = Enumerable.Range(1, n).ToArray();

        // Brute-force expected computation
        Stopwatch sw = Stopwatch.StartNew();
        var bruteForcedResult = _solution.Solve_BruteForce(nums);
        sw.Stop();

        Console.WriteLine(
            $"ProductsOfArrayExceptSelf: execution time of solving array of 1000 numbers O(n^2) took: {sw.GetElapsedNanoseconds()} ns"
        );

        // Act
        sw.Restart();
        var result = _solution.Solve(nums);
        sw.Stop();

        Console.WriteLine(
            $"ProductsOfArrayExceptSelf: execution time for solving array of 1000 numbers O(n) took: {sw.GetElapsedNanoseconds()} ns"
        );

        // Assert
        for (int i = 0; i < n; i++)
        {
            Assert.That(result[i], Is.EqualTo(bruteForcedResult[i]));
        }
    }
}
