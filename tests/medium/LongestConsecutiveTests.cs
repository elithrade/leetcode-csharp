using core.medium;

namespace tests.medium;

[TestFixture]
public class LongestConsecutiveTests
{
    private LongestConsecutive _solution;

    [SetUp]
    public void Setup()
    {
        _solution = new LongestConsecutive();
    }

    [Test]
    public void Solve_AllSameElement()
    {
        var nums = new[] { 7, 7, 7, 7 };
        var expected = 1; // Only one unique element

        var result = _solution.Solve(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Solve_EmptyArray()
    {
        var nums = Array.Empty<int>();
        var expected = 0; // No elements

        var result = _solution.Solve(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Solve_SingleElement()
    {
        var nums = new[] { 42 };
        var expected = 1; // Only one element

        var result = _solution.Solve(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Solve_NoConsecutiveNumbers()
    {
        var nums = new[] { 10, 30, 50, 70 };
        var expected = 1; // Each is isolated

        var result = _solution.Solve(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Solve_AllConsecutiveNumbers()
    {
        var nums = new[] { 5, 6, 7, 8, 9 };
        var expected = 5; // Entire array is consecutive

        var result = _solution.Solve(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Solve_UnorderedConsecutiveNumbers()
    {
        var nums = new[] { 100, 4, 200, 1, 3, 2 };
        var expected = 4; // Sequence [1,2,3,4]

        var result = _solution.Solve(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Solve_WithNegatives()
    {
        var nums = new[] { -2, -1, 0, 1, 2, 10 };
        var expected = 5; // Sequence [-2,-1,0,1,2]

        var result = _solution.Solve(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Solve_WithDuplicatesAndConsecutiveNumbers()
    {
        var nums = new[] { 1, 2, 2, 3 };
        var expected = 3; // Sequence [1,2,3]

        var result = _solution.Solve(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Solve_MultipleSequences()
    {
        var nums = new[] { 10, 11, 12, 50, 51, 1 };
        var expected = 3; // Sequence [10,11,12]

        var result = _solution.Solve(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Solve_LargeGapBetweenSequences()
    {
        var nums = new[] { 1, 2, 3, 1000, 1001 };
        var expected = 3; // Sequence [1,2,3]

        var result = _solution.Solve(nums);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Solve_LongArray()
    {
        var nums = Enumerable.Range(1, 100000).ToArray();
        var expected = 100000; // Whole range is consecutive

        var result = _solution.Solve(nums);
        Assert.That(result, Is.EqualTo(expected));
    }
}
