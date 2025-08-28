using core.medium;

namespace tests.medium;

[TestFixture]
public class TwoSumIITests
{
    [Test]
    public void TwoSumII_Example1_ShouldReturnCorrectIndices()
    {
        var solution = new TwoSumII();
        var numbers = new int[] { 2, 7, 11, 15 };
        var target = 9;
        var result = solution.Solve(numbers, target);
        Assert.That(result, Is.EqualTo(new int[] { 1, 2 }));
    }

    [Test]
    public void TwoSumII_Example2_ShouldReturnCorrectIndices()
    {
        var solution = new TwoSumII();
        var numbers = new int[] { 2, 3, 4 };
        var target = 6;
        var result = solution.Solve(numbers, target);
        Assert.That(result, Is.EqualTo(new int[] { 1, 3 }));
    }

    [Test]
    public void TwoSumII_Example3_ShouldReturnCorrectIndices()
    {
        var solution = new TwoSumII();
        var numbers = new int[] { -1, 0 };
        var target = -1;
        var result = solution.Solve(numbers, target);
        Assert.That(result, Is.EqualTo(new int[] { 1, 2 }));
    }

    [Test]
    public void TwoSumII_MinimumArraySize_ShouldReturnCorrectIndices()
    {
        var solution = new TwoSumII();
        var numbers = new int[] { 1, 2 };
        var target = 3;
        var result = solution.Solve(numbers, target);
        Assert.That(result, Is.EqualTo(new int[] { 1, 2 }));
    }

    [Test]
    public void TwoSumII_LargeNumbers_ShouldReturnCorrectIndices()
    {
        var solution = new TwoSumII();
        var numbers = new int[] { 1_000_000, 2_000_000, 3_000_000, 9_000_000 };
        var target = 11_000_000;
        var result = solution.Solve(numbers, target);
        Assert.That(result, Is.EqualTo(new int[] { 2, 4 }));
    }

    [Test]
    public void TwoSumII_NegativeAndPositiveNumbers_ShouldReturnCorrectIndices()
    {
        var solution = new TwoSumII();
        var numbers = new int[] { -10, -3, 0, 4, 9, 12 };
        var target = 1;
        var result = solution.Solve(numbers, target);
        Assert.That(result, Is.EqualTo(new int[] { 2, 4 }));
    }

    [Test]
    public void TwoSumII_TargetIsSumOfFirstAndLast_ShouldReturnCorrectIndices()
    {
        var solution = new TwoSumII();
        var numbers = new int[] { 5, 10, 15, 20 };
        var target = 25;
        var result = solution.Solve(numbers, target);
        Assert.That(result, Is.EqualTo(new int[] { 1, 4 }));
    }
}
