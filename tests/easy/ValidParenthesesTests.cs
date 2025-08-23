using core.easy;

namespace tests.easy;

[TestFixture]
public class ValidParenthesesTests
{
    [Test]
    public void IsValid_ValidParentheses_ReturnsTrue()
    {
        // Arrange
        var solution = new ValidParentheses();
        string s = "()[]{}";

        // Act
        var result = solution.IsValid(s);

        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void IsValid_ValidParentheses_SameParentheses_ReturnsTrue()
    {
        // Arrange
        var solution = new ValidParentheses();
        string s = "((((()))))";

        // Act
        var result = solution.IsValid(s);

        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void Solve_StartsWithClosingBrackets_ShouldReturnFalse()
    {
        var s = "))";

        var solution = new ValidParentheses();
        var result = solution.IsValid(s);

        Assert.That(result, Is.False);
    }

    [Test]
    public void Solve_StartsWithClosingBracket_ShouldReturnFalse()
    {
        var s = ")";

        var solution = new ValidParentheses();
        var result = solution.IsValid(s);

        Assert.That(result, Is.False);
    }

    [Test]
    public void Solve_ExtraClosingBracket_ShouldReturnFalse()
    {
        var s = "(()))";

        var solution = new ValidParentheses();
        var result = solution.IsValid(s);

        Assert.That(result, Is.False);
    }

    [Test]
    public void IsValid_InvalidParentheses_IncorrectOrder_ReturnsFalse()
    {
        // Arrange
        var solution = new ValidParentheses();
        string s = "([)]";

        // Act
        var result = solution.IsValid(s);

        // Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void IsValid_InvalidParentheses_ReturnsFalse()
    {
        // Arrange
        var solution = new ValidParentheses();
        string s = "(]";

        // Act
        var result = solution.IsValid(s);

        // Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void IsValid_EmptyString_ReturnsTrue()
    {
        // Arrange
        var solution = new ValidParentheses();
        string s = "";

        // Act
        var result = solution.IsValid(s);

        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void IsValid_NestedParentheses_ReturnsTrue()
    {
        // Arrange
        var solution = new ValidParentheses();
        string s = "([{}])";

        // Act
        var result = solution.IsValid(s);

        // Assert
        Assert.That(result, Is.True);
    }
}
