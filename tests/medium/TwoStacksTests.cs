using core.medium;

namespace tests.medium;

[TestFixture]
public class TwoStacksTests
{
    private TwoStacks _twoStacks;

    [SetUp]
    public void SetUp()
    {
        _twoStacks = new TwoStacks();
    }

    [Test]
    public void Should_PushAndPopElementsCorrectly()
    {
        _twoStacks.Push(5);
        _twoStacks.Push(3);
        Assert.That(_twoStacks.Top(), Is.EqualTo(3));
        _twoStacks.Pop();
        Assert.That(_twoStacks.Top(), Is.EqualTo(5));
    }

    [Test]
    public void Should_KeepMin_WhenValuesIncrease()
    {
        _twoStacks.Push(1);
        _twoStacks.Push(2);
        _twoStacks.Push(3);

        Assert.That(_twoStacks.GetMin(), Is.EqualTo(1));
    }

    [Test]
    public void Should_UpdateMin_WhenPoppingBackUp()
    {
        _twoStacks.Push(5);
        _twoStacks.Push(3);
        _twoStacks.Push(1);
        _twoStacks.Pop(); // remove 1

        Assert.That(_twoStacks.GetMin(), Is.EqualTo(3));
    }

    [Test]
    public void Should_TrackMinCorrectly_WhenValuesDecrease()
    {
        _twoStacks.Push(5);
        Assert.That(_twoStacks.GetMin(), Is.EqualTo(5));

        _twoStacks.Push(3);
        Assert.That(_twoStacks.GetMin(), Is.EqualTo(3));

        _twoStacks.Push(1);
        Assert.That(_twoStacks.GetMin(), Is.EqualTo(1));
    }

    [Test]
    public void Should_HandleDuplicateMinimums()
    {
        _twoStacks.Push(2);
        _twoStacks.Push(2);
        _twoStacks.Push(3);

        Assert.That(_twoStacks.GetMin(), Is.EqualTo(2));

        _twoStacks.Pop(); // pop 3
        Assert.That(_twoStacks.GetMin(), Is.EqualTo(2));

        _twoStacks.Pop(); // pop 2
        Assert.That(_twoStacks.GetMin(), Is.EqualTo(2));
    }
}
