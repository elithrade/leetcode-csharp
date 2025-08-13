using core.easy;

namespace tests.easy
{
    [TestFixture]
    public class ValidAnagramTests
    {
        [Test]
        public void IsAnagram_ValidAnagrams_ReturnsTrue()
        {
            // Arrange
            var solution = new Solution();
            string s = "listen";
            string t = "silent";

            // Act
            var result = solution.IsAnagram(s, t);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsAnagram_InvalidAnagrams_ReturnsFalse()
        {
            // Arrange
            var solution = new Solution();
            string s = "hello";
            string t = "world";

            // Act
            var result = solution.IsAnagram(s, t);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsAnagram_DifferentLengths_ReturnsFalse()
        {
            // Arrange
            var solution = new Solution();
            string s = "abc";
            string t = "abcd";

            // Act
            var result = solution.IsAnagram(s, t);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsAnagram_EmptyStrings_ReturnsTrue()
        {
            // Arrange
            var solution = new Solution();
            string s = "";
            string t = "";

            // Act
            var result = solution.IsAnagram(s, t);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsAnagram_SameCharactersDifferentCounts_ReturnsFalse()
        {
            // Arrange
            var solution = new Solution();
            string s = "aabb";
            string t = "ab";

            // Act
            var result = solution.IsAnagram(s, t);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsAnagram_VeryLongAnagram_ReturnsFalse()
        {
            // Arrange
            var solution = new Solution();
            string s = new string('a', 10000) + new string('b', 9999) + new string('c', 10000);
            string t = new string('c', 9999) + new string('b', 10000) + new string('a', 10000);

            // Act
            var result = solution.IsAnagram(s, t);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsAnagram_VeryLongAnagram_ReturnsTrue()
        {
            // Arrange
            var solution = new Solution();
            string s = new string('a', 10000) + new string('b', 10000) + new string('c', 10000);
            string t = new string('c', 10000) + new string('b', 10000) + new string('a', 10000);

            // Act
            var result = solution.IsAnagram(s, t);

            // Assert
            Assert.That(result, Is.True);
        }
    }
}
