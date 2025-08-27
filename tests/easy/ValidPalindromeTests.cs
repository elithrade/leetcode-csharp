using core.easy;

namespace tests.easy;

[TestFixture]
public class ValidPalindromeTests
{
    [Test]
    public void IsValidPalindrome_Example1_ShouldReturnTrue()
    {
        var solution = new ValidPalindrome();
        var input = "Was it a car or a cat I saw?";
        var result = solution.Solve(input);
        Assert.That(result, Is.True);
    }

    [Test]
    public void IsValidPalindrome_Example2_ShouldReturnFalse()
    {
        var solution = new ValidPalindrome();
        var input = "tab a cat";
        var result = solution.Solve(input);
        Assert.That(result, Is.False);
    }

    [Test]
    public void IsValidPalindrome_EmptyString_ShouldReturnTrue()
    {
        var solution = new ValidPalindrome();
        var input = "";
        var result = solution.Solve(input);
        Assert.That(result, Is.True);
    }

    [Test]
    public void IsValidPalindrome_SingleCharacter_ShouldReturnTrue()
    {
        var solution = new ValidPalindrome();
        var input = "a";
        var result = solution.Solve(input);
        Assert.That(result, Is.True);
    }

    [Test]
    public void IsValidPalindrome_SingleCharacterWithPunctuation_ShouldReturnTrue()
    {
        var solution = new ValidPalindrome();
        var input = "!a@";
        var result = solution.Solve(input);
        Assert.That(result, Is.True);
    }

    [Test]
    public void IsValidPalindrome_OnlyPunctuation_ShouldReturnTrue()
    {
        var solution = new ValidPalindrome();
        var input = "!@#$%^&*()";
        var result = solution.Solve(input);
        Assert.That(result, Is.True);
    }

    [Test]
    public void IsValidPalindrome_SimpleOddLength_ShouldReturnTrue()
    {
        var solution = new ValidPalindrome();
        var input = "racecar";
        var result = solution.Solve(input);
        Assert.That(result, Is.True);
    }

    [Test]
    public void IsValidPalindrome_SimpleEvenLength_ShouldReturnTrue()
    {
        var solution = new ValidPalindrome();
        var input = "abba";
        var result = solution.Solve(input);
        Assert.That(result, Is.True);
    }

    [Test]
    public void IsValidPalindrome_MixedCase_ShouldReturnTrue()
    {
        var solution = new ValidPalindrome();
        var input = "Aa";
        var result = solution.Solve(input);
        Assert.That(result, Is.True);
    }

    [Test]
    public void IsValidPalindrome_AlphanumericMixed_ShouldReturnTrue()
    {
        var solution = new ValidPalindrome();
        var input = "A man a plan a canal Panama";
        var result = solution.Solve(input);
        Assert.That(result, Is.True);
    }

    [Test]
    public void IsValidPalindrome_NumbersAndLetters_ShouldReturnTrue()
    {
        var solution = new ValidPalindrome();
        var input = "12321";
        var result = solution.Solve(input);
        Assert.That(result, Is.True);
    }

    [Test]
    public void IsValidPalindrome_NumbersAndLettersMixed_ShouldReturnTrue()
    {
        var solution = new ValidPalindrome();
        var input = "A1B2b1a";
        var result = solution.Solve(input);
        Assert.That(result, Is.True);
    }

    [Test]
    public void IsValidPalindrome_WithSpacesAndPunctuation_ShouldReturnTrue()
    {
        var solution = new ValidPalindrome();
        var input = "Madam, I'm Adam";
        var result = solution.Solve(input);
        Assert.That(result, Is.True);
    }

    [Test]
    public void IsValidPalindrome_NotPalindrome_ShouldReturnFalse()
    {
        var solution = new ValidPalindrome();
        var input = "hello";
        var result = solution.Solve(input);
        Assert.That(result, Is.False);
    }

    [Test]
    public void IsValidPalindrome_TwoCharactersNotPalindrome_ShouldReturnFalse()
    {
        var solution = new ValidPalindrome();
        var input = "ab";
        var result = solution.Solve(input);
        Assert.That(result, Is.False);
    }

    [Test]
    public void IsValidPalindrome_WithNumbersNotPalindrome_ShouldReturnFalse()
    {
        var solution = new ValidPalindrome();
        var input = "1a2";
        var result = solution.Solve(input);
        Assert.That(result, Is.False);
    }

    [Test]
    public void IsValidPalindrome_LongStringNotPalindrome_ShouldReturnFalse()
    {
        var solution = new ValidPalindrome();
        var input = "This is definitely not a palindrome";
        var result = solution.Solve(input);
        Assert.That(result, Is.False);
    }

    [Test]
    public void IsValidPalindrome_AlmostPalindrome_ShouldReturnFalse()
    {
        var solution = new ValidPalindrome();
        var input = "abcba1"; // Extra character at end
        var result = solution.Solve(input);
        Assert.That(result, Is.False);
    }
}
