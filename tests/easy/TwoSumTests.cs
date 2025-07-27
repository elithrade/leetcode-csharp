using NUnit.Framework;
using NUnit.Framework.Constraints;
using core.easy;

namespace easy.tests
{
    [TestFixture]
    public class TwoSumTests
    {
        [Test]
        public void TwoSum_ReturnsCorrectIndices_Example1()
        {
            var solution = new TwoSum();
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] expected = { 0, 1 };

            int[] actual = solution.Solve(nums, target);

            Assert.That(actual, Is.Not.Null);
            Assert.That(actual.Length, Is.EqualTo(expected.Length));
            Assert.That(actual, Contains.Item(expected[0]));
            Assert.That(actual, Contains.Item(expected[1]));
        }

        [Test]
        public void TwoSum_ReturnsCorrectIndices_Example2()
        {
            var solution = new TwoSum();
            int[] nums = { 3, 2, 4 };
            int target = 6;
            int[] expected = { 1, 2 };

            int[] actual = solution.Solve(nums, target);

            Assert.That(actual, Is.Not.Null);
            Assert.That(actual.Length, Is.EqualTo(expected.Length));
            Assert.That(actual, Contains.Item(expected[0]));
            Assert.That(actual, Contains.Item(expected[1]));
        }

        [Test]
        public void TwoSum_ReturnsCorrectIndices_Example3()
        {
            var solution = new TwoSum();
            int[] nums = { 3, 3 };
            int target = 6;
            int[] expected = { 0, 1 };

            int[] actual = solution.Solve(nums, target);

            Assert.That(actual, Is.Not.Null);
            Assert.That(actual.Length, Is.EqualTo(expected.Length));
            Assert.That(actual, Contains.Item(expected[0]));
            Assert.That(actual, Contains.Item(expected[1]));
        }

        [Test]
        public void TwoSum_ThrowsException_NoSolution()
        {
            var solution = new TwoSum();
            int[] nums = { 1, 2, 3 };
            int target = 10;

            Assert.Throws<System.ArgumentException>(() => solution.Solve(nums, target));
        }
    }
}
