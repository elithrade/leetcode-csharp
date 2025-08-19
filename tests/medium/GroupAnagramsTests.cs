using core.medium;

namespace tests.medium;

[TestFixture]
public class GroupAnagramsTests
{
    [Test]
    public void Solve_ValidAnagrams_ReturnsGroupedAnagrams()
    {
        // Arrange
        var solution = new GroupAnagrams();
        string[] strs = ["eat", "tea", "tan", "ate", "nat", "bat"];

        // Act
        var result = solution.Solve(strs);

        // Assert
        Assert.That(result.Count, Is.EqualTo(3));
        Assert.That(result[0], Is.EquivalentTo(new[] { "eat", "tea", "ate" }));
        Assert.That(result[1], Is.EquivalentTo(new[] { "tan", "nat" }));
        Assert.That(result[2], Is.EquivalentTo(new[] { "bat" }));
    }

    [Test]
    public void SolveUsingCharacterCount_ValidAnagrams_ReturnsGroupedAnagrams()
    {
        // Arrange
        var solution = new GroupAnagrams();
        string[] strs = ["eat", "tea", "tan", "ate", "nat", "bat"];

        // Act
        var result = solution.Solve_Using_Character_Count(strs);

        // Assert
        Assert.That(result.Count, Is.EqualTo(3));
        Assert.That(result[0], Is.EquivalentTo(new[] { "eat", "tea", "ate" }));
        Assert.That(result[1], Is.EquivalentTo(new[] { "tan", "nat" }));
        Assert.That(result[2], Is.EquivalentTo(new[] { "bat" }));
    }

    [Test]
    public void Solve_EmptyArray_ReturnsEmptyList()
    {
        // Arrange
        var solution = new GroupAnagrams();
        string[] strs = [];

        // Act
        var result = solution.Solve(strs);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Solve_SingleString_ReturnsSingleGroup()
    {
        // Arrange
        var solution = new GroupAnagrams();
        string[] strs = ["hello"];

        // Act
        var result = solution.Solve(strs);

        // Assert
        Assert.That(result.Count, Is.EqualTo(1));
        Assert.That(result[0], Is.EquivalentTo(new[] { "hello" }));
    }

    [Test]
    public void Solve_AllUniqueStrings_NoAnagrams_ReturnsEachAsSeparateGroup()
    {
        // Arrange
        var solution = new GroupAnagrams();
        string[] strs = ["one", "two", "three"];

        // Act
        var result = solution.Solve(strs);

        // Assert
        Assert.That(result.Count, Is.EqualTo(3));
        Assert.That(result, Has.All.Matches<IEnumerable<string>>(g => g.Count() == 1));
    }

    [Test]
    public void Solve_AllStringsAreSame_ReturnsSingleGroupWithAll()
    {
        // Arrange
        var solution = new GroupAnagrams();
        string[] strs = ["abc", "abc", "abc"];

        // Act
        var result = solution.Solve(strs);

        // Assert
        Assert.That(result.Count, Is.EqualTo(1));
        Assert.That(result[0], Is.EquivalentTo(new[] { "abc", "abc", "abc" }));
    }

    [Test]
    public void Solve_MixedCaseStrings_TreatsDifferentCasesAsDistinct()
    {
        // Arrange
        var solution = new GroupAnagrams();
        string[] strs = ["Eat", "tea", "ATE"];

        // Act
        var result = solution.Solve(strs);

        // Assert
        Assert.That(result.Count, Is.EqualTo(3)); // Case-sensitive
        Assert.That(result, Has.All.Matches<IEnumerable<string>>(g => g.Count() == 1));
    }

    [Test]
    public void Solve_StringsWithSpacesOrPunctuation_GroupsCorrectly()
    {
        // Arrange
        var solution = new GroupAnagrams();
        string[] strs = ["a bc", "cba", "bac", "bca", "cab"];

        // Act
        var result = solution.Solve(strs);

        // Assert
        // "a bc" won't match others unless spaces are ignored
        Assert.That(
            result.Any(g =>
                g.Contains("cba") && g.Contains("bac") && g.Contains("bca") && g.Contains("cab")
            ),
            Is.True
        );
    }

    [Test]
    public void Solve_LongStrings_GroupsCorrectly()
    {
        // Arrange
        var solution = new GroupAnagrams();
        string longStr1 = new string('a', 1000) + "b";
        string longStr2 = "b" + new string('a', 1000);
        string longStr3 = new string('a', 1001);

        string[] strs = [longStr1, longStr2, longStr3];

        // Act
        var result = solution.Solve(strs);

        // Assert
        Assert.That(result.Count, Is.EqualTo(2));
        Assert.That(result.Any(g => g.Contains(longStr1) && g.Contains(longStr2)), Is.True);
        Assert.That(result.Any(g => g.Contains(longStr3)), Is.True);
    }

    [Test]
    public void Solve_EmptyStrings_GroupsTogether()
    {
        // Arrange
        var solution = new GroupAnagrams();
        string[] strs = ["", "", "a"];

        // Act
        var result = solution.Solve(strs);

        // Assert
        Assert.That(result.Count, Is.EqualTo(2));
        Assert.That(result.Any(g => g.All(s => s == "")), Is.True);
    }
}
