using core.easy;

namespace tests.easy
{
    [TestFixture]
    public class ContainsDuplicateTests
    {
        [Test]
        public void ContainsDuplicate_ReturnsTrue_WhenDuplicatesExist()
        {
            var solution = new ContainsDuplicate();
            int[] nums = { 1, 2, 3, 1 };
            bool expected = true;

            bool actual = solution.Solve(nums);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ContainsDuplicate_ReturnsFalse_WhenNoDuplicatesExist()
        {
            var solution = new ContainsDuplicate();
            int[] nums = { 1, 2, 3, 4 };
            bool expected = false;

            bool actual = solution.Solve(nums);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ContainsDuplicate_ReturnsTrue_WhenAllElementsAreTheSame()
        {
            var solution = new ContainsDuplicate();
            int[] nums = { 2, 2, 2, 2 };
            bool expected = true;

            bool actual = solution.Solve(nums);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
