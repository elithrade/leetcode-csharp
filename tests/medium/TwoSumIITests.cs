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
        int[] expected = [1, 2];
        var result = solution.Solve(numbers, target);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void TwoSumII_Example2_ShouldReturnCorrectIndices()
    {
        var solution = new TwoSumII();
        var numbers = new int[] { 2, 3, 4 };
        var target = 6;
        int[] expected = [1, 3];

        var result = solution.Solve(numbers, target);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void TwoSumII_Example3_ShouldReturnCorrectIndices()
    {
        var solution = new TwoSumII();
        var numbers = new int[] { -1, 0 };
        var target = -1;
        int[] expected = [1, 2];

        var result = solution.Solve(numbers, target);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void TwoSumII_MinimumArraySize_ShouldReturnCorrectIndices()
    {
        var solution = new TwoSumII();
        var numbers = new int[] { 1, 2 };
        var target = 3;
        int[] expected = [1, 2];

        var result = solution.Solve(numbers, target);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void TwoSumII_LargeNumbers_ShouldReturnCorrectIndices()
    {
        var solution = new TwoSumII();
        var numbers = new int[] { 1_000_000, 2_000_000, 3_000_000, 9_000_000 };
        var target = 11_000_000;
        int[] expected = [2, 4];

        var result = solution.Solve(numbers, target);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void TwoSumII_NegativeAndPositiveNumbers_ShouldReturnCorrectIndices()
    {
        var solution = new TwoSumII();
        var numbers = new int[] { -10, -3, 0, 4, 9, 12 };
        var target = 1;
        int[] expected = [2, 4];

        var result = solution.Solve(numbers, target);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void TwoSumII_TargetIsSumOfFirstAndLast_ShouldReturnCorrectIndices()
    {
        var solution = new TwoSumII();
        var numbers = new int[] { 5, 10, 15, 20 };
        var target = 25;
        int[] expected = [1, 4];

        var result = solution.Solve(numbers, target);
        Assert.That(result, Is.EqualTo(expected));
    }
}
