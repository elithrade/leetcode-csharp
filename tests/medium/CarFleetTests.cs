using core.medium;

namespace tests.medium;

[TestFixture]
public class CarFleetTests
{
    [Test]
    public void Solve_SimpleExample_ReturnsExpectedOutput()
    {
        var solution = new CarFleet();
        // Arrange
        int target = 10;
        int[] position = [1, 4];
        int[] speed = [3, 2];
        int expected = 1;

        // Act
        var result = solution.Solve(target, position, speed);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Solve_Example1_ReturnsExpectedOutput()
    {
        var solution = new CarFleet();
        // Arrange
        int target = 12;
        int[] position = [10, 8, 0, 5, 3];
        int[] speed = [2, 4, 1, 1, 3];
        int expected = 3;

        // Act
        var result = solution.Solve(target, position, speed);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Solve_Example2_ReturnsExpectedOutput()
    {
        var solution = new CarFleet();
        // Arrange
        int target = 10;
        int[] position = [3];
        int[] speed = [3];
        int expected = 1;

        // Act
        var result = solution.Solve(target, position, speed);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Solve_Example3_ReturnsExpectedOutput()
    {
        var solution = new CarFleet();
        // Arrange
        int target = 100;
        int[] position = [0, 2, 4];
        int[] speed = [4, 2, 1];
        int expected = 1;

        // Act
        var result = solution.Solve(target, position, speed);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Solve_AllCarsSameSpeed_ReturnsNumberOfCars()
    {
        var solution = new CarFleet();
        // Arrange
        int target = 15;
        int[] position = [1, 5, 8, 12];
        int[] speed = [2, 2, 2, 2];
        int expected = 4;
        // Act
        var result = solution.Solve(target, position, speed);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Solve_FasterCarBehindSlowerCar_FormsSingleFleet()
    {
        var solution = new CarFleet();
        // Arrange
        int target = 20;
        int[] position = [5, 10];
        int[] speed = [10, 1];
        int expected = 1;
        // Act
        var result = solution.Solve(target, position, speed);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Solve_LargeTarget_HandlesCorrectly()
    {
        var solution = new CarFleet();
        // Arrange
        int target = 1000;
        int[] position = [100, 300, 500, 700];
        int[] speed = [10, 5, 3, 2];
        int expected = 2;
        // Act
        var result = solution.Solve(target, position, speed);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
        Assert.That(result, Is.EqualTo(expected));
    }
}
