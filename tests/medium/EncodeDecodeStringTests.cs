using core.medium;

namespace tests.medium;

[TestFixture]
public class EncodeDecodeStringTests
{
    [Test]
    public void Encode_ValidStrings_ReturnsEncodedString()
    {
        // Arrange
        var solution = new EncodeDecodeString();
        IList<string> strs = ["hello", "world"];

        // Act
        var result = solution.Encode(strs);

        // Assert
        Assert.That(result, Is.EqualTo("5#hello5#world"));
    }

    [Test]
    public void Decode_ValidEncodedString_ReturnsDecodedList()
    {
        // Arrange
        var solution = new EncodeDecodeString();
        string encoded = "5#hello5#world";

        // Act
        var result = solution.Decode(encoded);

        // Assert
        Assert.That(result, Is.EquivalentTo(new List<string> { "hello", "world" }));
    }

    [Test]
    public void Encode_EmptyList_ReturnsEmptyString()
    {
        var solution = new EncodeDecodeString();
        IList<string> strs = [];

        var result = solution.Encode(strs);

        Assert.That(result, Is.EqualTo(""));
    }

    [Test]
    public void Decode_EmptyString_ReturnsEmptyList()
    {
        var solution = new EncodeDecodeString();

        var result = solution.Decode("");

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void EncodeDecode_SingleEmptyString_WorksCorrectly()
    {
        var solution = new EncodeDecodeString();
        IList<string> strs = [""];

        var encoded = solution.Encode(strs);
        var decoded = solution.Decode(encoded);

        Assert.Multiple(() =>
        {
            Assert.That(encoded, Is.EqualTo("0#"));
            Assert.That(decoded, Is.EquivalentTo(new List<string> { "" }));
        });
    }

    [Test]
    public void EncodeDecode_StringsWithDelimiterCharacters_WorksCorrectly()
    {
        var solution = new EncodeDecodeString();
        IList<string> strs = ["abc#def", "123#456"];

        var encoded = solution.Encode(strs);
        var decoded = solution.Decode(encoded);

        Assert.That(decoded, Is.EquivalentTo(strs));
    }

    [Test]
    public void EncodeDecode_StringsWithNumbers_WorksCorrectly()
    {
        var solution = new EncodeDecodeString();
        IList<string> strs = ["123", "4567", "890"];

        var encoded = solution.Encode(strs);
        var decoded = solution.Decode(encoded);

        Assert.That(decoded, Is.EquivalentTo(strs));
    }

    [Test]
    public void EncodeDecode_StringsWithSpecialCharacters_WorksCorrectly()
    {
        var solution = new EncodeDecodeString();
        IList<string> strs = ["!@#$%^", "😊👍", "line\nbreak"];

        var encoded = solution.Encode(strs);
        var decoded = solution.Decode(encoded);

        Assert.That(decoded, Is.EquivalentTo(strs));
    }

    [Test]
    public void EncodeDecode_LongString_WorksCorrectly()
    {
        var solution = new EncodeDecodeString();
        string longStr = new('a', 1000);
        IList<string> strs = [longStr, "short"];

        var encoded = solution.Encode(strs);
        var decoded = solution.Decode(encoded);

        Assert.That(decoded, Is.EquivalentTo(strs));
    }

    [Test]
    public void EncodeDecode_MultipleEmptyStrings_WorksCorrectly()
    {
        var solution = new EncodeDecodeString();
        IList<string> strs = ["", "", ""];

        var encoded = solution.Encode(strs);
        var decoded = solution.Decode(encoded);

        Assert.That(decoded, Is.EquivalentTo(strs));
    }

    [Test]
    public void EncodeDecode_RoundTripConsistency()
    {
        var solution = new EncodeDecodeString();
        IList<string> strs = ["foo", "bar#baz", "", "123"];

        var encoded = solution.Encode(strs);
        var decoded = solution.Decode(encoded);
        var reEncoded = solution.Encode(decoded);

        Assert.Multiple(() =>
        {
            Assert.That(decoded, Is.EquivalentTo(strs));
            Assert.That(reEncoded, Is.EqualTo(encoded));
        });
    }
}
