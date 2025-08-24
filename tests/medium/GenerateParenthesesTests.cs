using core.medium;

namespace tests.medium;

[TestFixture]
public class GenerateParenthesesTests
{
    [Test]
    public void Generate_ThreePairs_ReturnsCorrectCombinations()
    {
        // Arrange
        var solution = new GenerateParentheses();
        int n = 3;

        // Act
        var result = solution.Generate(n);

        // Assert
        var expected = new List<string> { "((()))", "(()())", "(())()", "()(())", "()()()" };

        Assert.That(result, Is.EquivalentTo(expected));
    }

    [Test]
    public void Generate_OnePair_ReturnsSingleCombination()
    {
        // Arrange
        var solution = new GenerateParentheses();
        int n = 1;

        // Act
        var result = solution.Generate(n);

        // Assert
        var expected = new List<string> { "()" };
        Assert.That(result, Is.EquivalentTo(expected));
    }

    [Test]
    public void Generate_TwoPairs_ReturnsCorrectCombinations()
    {
        // Arrange
        var solution = new GenerateParentheses();
        int n = 2;

        // Act
        var result = solution.Generate(n);

        // Assert
        var expected = new List<string> { "(())", "()()" };
        Assert.That(result, Is.EquivalentTo(expected));
    }

    [Test]
    public void Generate_ZeroPairs_ReturnsEmptyStringOnly()
    {
        // Arrange
        var solution = new GenerateParentheses();
        int n = 0;

        // Act
        var result = solution.Generate(n);

        // Assert
        var expected = new List<string> { "" };
        Assert.That(result, Is.EquivalentTo(expected));
    }

    [Test]
    public void Generate_FourPairs_ReturnsCorrectNumberOfCombinations()
    {
        // Arrange
        var solution = new GenerateParentheses();
        int n = 4;

        // Act
        var result = solution.Generate(n);

        // Assert
        // 4 pairs should generate 14 combinations (the 4th Catalan number)
        Assert.That(result, Has.Count.EqualTo(14));
    }
}
