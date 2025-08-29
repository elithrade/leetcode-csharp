using core.medium;

namespace tests.medium;

[TestFixture]
public class ThreeSumTests
{
    [Test]
    public void ThreeSum_Returns_Correct_Indices_Example1()
    {
        var solution = new ThreeSum();
        var result = solution.Solve([-1, 0, 1, 2, -1, -4]);
        List<List<int>> expected =
        [
            [-1, -1, 2],
            [-1, 0, 1],
        ];

        Assert.That(result, Is.EquivalentTo(expected));
    }

    [Test]
    public void ThreeSum_Handles_Duplicates_Correctly()
    {
        var solution = new ThreeSum();
        var result = solution.Solve([-2, 0, 0, 2, 2]);

        List<List<int>> expected =
        [
            [-2, 0, 2],
        ];

        Assert.That(result, Is.EquivalentTo(expected));
    }

    [Test]
    public void ThreeSum_Handles_Duplicates_LeftAndRight_Correctly()
    {
        var solution = new ThreeSum();
        var result = solution.Solve([-2, 0, 0, 2, 2, 2]);

        List<List<int>> expected =
        [
            [-2, 0, 2],
        ];

        Assert.That(result, Is.EquivalentTo(expected));
    }

    [Test]
    public void ThreeSum_DuplicatesOnRight_WithoutSkippingRight_Fails()
    {
        var solution = new ThreeSum();
        var result = solution.Solve([-2, -2, 0, 0, 2, 2, 2, 2]);

        List<List<int>> expected =
        [
            [-2, 0, 2],
        ];

        Assert.That(result, Is.EquivalentTo(expected));
    }
}
