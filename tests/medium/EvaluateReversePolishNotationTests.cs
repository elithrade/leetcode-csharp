using core.medium;

namespace tests.medium;

[TestFixture]
public class EvaluateReversePolishNotationTests
{
    [Test]
    public void EvalRPN_ValidExpression_ReturnsCorrectResult()
    {
        // Arrange
        var solution = new EvaluateReversePolishNotation();
        string[] tokens = ["2", "1", "+", "3", "*"];

        // Act
        var result = solution.EvalRPN(tokens);

        // Assert
        Assert.That(result, Is.EqualTo(9));
    }

    [Test]
    public void EvalRPN_AnotherValidExpression_ReturnsCorrectResult()
    {
        // Arrange
        var solution = new EvaluateReversePolishNotation();
        string[] tokens = ["1", "2", "+", "3", "*", "4", "-"];

        // Act
        var result = solution.EvalRPN(tokens);

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void EvalRPN_SingleNumber_ReturnsThatNumber()
    {
        // Arrange
        var solution = new EvaluateReversePolishNotation();
        string[] tokens = ["42"];

        // Act
        var result = solution.EvalRPN(tokens);

        // Assert
        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void EvalRPN_Subtraction_WorksCorrectly()
    {
        var solution = new EvaluateReversePolishNotation();
        string[] tokens = ["5", "3", "-"];

        var result = solution.EvalRPN(tokens);

        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void EvalRPN_Division_TruncatesTowardZero()
    {
        var solution = new EvaluateReversePolishNotation();
        string[] tokens = ["10", "3", "/"];

        var result = solution.EvalRPN(tokens);

        Assert.That(result, Is.EqualTo(3)); // 10/3 = 3.333… -> truncates to 3
    }

    [Test]
    public void EvalRPN_DivisionWithNegativeNumbers_TruncatesTowardZero()
    {
        var solution = new EvaluateReversePolishNotation();
        string[] tokens = ["-7", "2", "/"];

        var result = solution.EvalRPN(tokens);

        Assert.That(result, Is.EqualTo(-3)); // -7/2 = -3.5 -> truncates toward zero
    }

    [Test]
    public void EvalRPN_ComplexExpression_ReturnsCorrectResult()
    {
        var solution = new EvaluateReversePolishNotation();
        string[] tokens = ["4", "13", "5", "/", "+"];

        var result = solution.EvalRPN(tokens);

        Assert.That(result, Is.EqualTo(6)); // 13/5 = 2, 4+2=6
    }

    [Test]
    public void EvalRPN_WithNegativeNumbers_ReturnsCorrectResult()
    {
        var solution = new EvaluateReversePolishNotation();
        string[] tokens = ["-2", "3", "*", "4", "+"];

        var result = solution.EvalRPN(tokens);

        Assert.That(result, Is.EqualTo(-2)); // (-2*3)+4 = -6+4 = -2
    }
}
