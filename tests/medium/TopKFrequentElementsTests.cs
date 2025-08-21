using System.Diagnostics;
using core.medium;

namespace tests.medium;

[TestFixture]
public class TopKFrequentElementsTests
{
    [Test]
    public void Solve_ShouldReturnTopKFrequentElements()
    {
        // Arrange
        var solution = new TopKFrequentElements();
        var nums = new[] { 1, 1, 1, 2, 2, 3, 10 };
        var k = 2;
        var expected = new[] { 1, 2 };

        // Act
        var result = solution.Solve(nums, k);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void SingleElementArray_ReturnsThatElement()
    {
        var solution = new TopKFrequentElements();
        var nums = new[] { 5 };
        var k = 1;
        var expected = new[] { 5 };

        var result = solution.Solve(nums, k);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void AllElementsUnique_KEqualsLength_ReturnsAllInAnyOrder()
    {
        var solution = new TopKFrequentElements();
        var nums = new[] { 4, 5, 6, 7 };
        var k = 4;

        var result = solution.Solve(nums, k);

        Assert.That(result.OrderBy(x => x), Is.EqualTo(nums.OrderBy(x => x)));
    }

    [Test]
    public void TieOnFrequency_ReturnsAnyValidSubset()
    {
        var solution = new TopKFrequentElements();
        var nums = new[] { 1, 1, 2, 2, 3, 3 };
        var k = 2;

        var result = solution.Solve(nums, k);

        // Since all have same frequency, any combination of 2 elements is valid
        Assert.That(result, Has.Length.EqualTo(2));
        Assert.That(result.All(x => new[] { 1, 2, 3 }.Contains(x)), Is.True);
    }

    [Test]
    public void KIsOne_ReturnsMostFrequentElement()
    {
        var solution = new TopKFrequentElements();
        var nums = new[] { 1, 1, 2, 3, 3, 3, 2, 2, 2 };
        var k = 1;
        var expected = new[] { 2 }; // 2 appears 4 times, more than any other

        var result = solution.Solve(nums, k);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void NegativeNumbers_AreHandledCorrectly()
    {
        var solution = new TopKFrequentElements();
        var nums = new[] { -1, -1, -2, -2, -2, 3 };
        var k = 2;
        var expected = new[] { -2, -1 };

        var result = solution.Solve(nums, k);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void LargeInputArray_StillReturnsCorrectResult()
    {
        var solution = new TopKFrequentElements();
        var nums = Enumerable
            .Repeat(1, 1000)
            .Concat(Enumerable.Repeat(2, 500))
            .Concat(Enumerable.Repeat(3, 200))
            .ToArray();

        var k = 2;
        var expected = new[] { 1, 2 };

        Stopwatch stopwatch = Stopwatch.StartNew();
        var result = solution.Solve(nums, k);
        stopwatch.Stop();
        Assert.That(result, Is.EqualTo(expected));

        Console.WriteLine(
            $"GroupAnagrams: execution time for solving array of 1700 numbers O(n): {stopwatch.GetElapsedNanoseconds()} ns"
        );

        stopwatch.Restart();
        var resultMinHeap = solution.Solve_UsingMinHeap(nums, k);
        stopwatch.Stop();
        // Use Equivalent here due to the order if different.
        Assert.That(resultMinHeap, Is.EquivalentTo(expected));

        Console.WriteLine(
            $"GroupAnagrams: execution time for solving array of 1700 numbers O(n*log*k): {stopwatch.GetElapsedNanoseconds()} ns"
        );
    }

    [Test]
    public void EmptyArray_ReturnsEmptyArray()
    {
        var solution = new TopKFrequentElements();
        var nums = Array.Empty<int>();
        var k = 1;

        var result = solution.Solve(nums, k);

        Assert.That(result, Is.Empty);
    }
}
