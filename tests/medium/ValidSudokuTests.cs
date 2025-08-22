using core.medium;

namespace tests.medium;

[TestFixture]
public class ValidSudokuTests()
{
    [Test]
    public void Should_ReturnTrueForValidSudoku()
    {
        char[][] input =
        [
            ['1', '2', '.', '.', '3', '.', '.', '.', '.'],
            ['4', '.', '.', '5', '.', '.', '.', '.', '.'],
            ['.', '9', '8', '.', '.', '.', '.', '.', '3'],
            ['5', '.', '.', '.', '6', '.', '.', '.', '4'],
            ['.', '.', '.', '8', '.', '3', '.', '.', '5'],
            ['7', '.', '.', '.', '2', '.', '.', '.', '6'],
            ['.', '.', '.', '.', '.', '.', '2', '.', '.'],
            ['.', '.', '.', '4', '1', '9', '.', '.', '8'],
            ['.', '.', '.', '.', '8', '.', '.', '7', '9'],
        ];

        var sudoku = new ValidSudoku();
        var output = sudoku.IsValidSudoku(input);

        Assert.That(output, Is.True);
    }

    [Test]
    public void Should_ReturnFalse_WhenRowHasDuplicate()
    {
        char[][] input =
        [
            ['1', '1', '.', '.', '3', '.', '.', '.', '.'], // duplicate '1' in row
            ['4', '.', '.', '5', '.', '.', '.', '.', '.'],
            ['.', '9', '8', '.', '.', '.', '.', '.', '3'],
            ['5', '.', '.', '.', '6', '.', '.', '.', '4'],
            ['.', '.', '.', '8', '.', '3', '.', '.', '5'],
            ['7', '.', '.', '.', '2', '.', '.', '.', '6'],
            ['.', '.', '.', '.', '.', '.', '2', '.', '.'],
            ['.', '.', '.', '4', '1', '9', '.', '.', '8'],
            ['.', '.', '.', '.', '8', '.', '.', '7', '9'],
        ];

        var sudoku = new ValidSudoku();
        var output = sudoku.IsValidSudoku(input);

        Assert.That(output, Is.False);
    }

    [Test]
    public void Should_ReturnFalse_WhenColumnHasDuplicate()
    {
        char[][] input =
        [
            ['1', '2', '.', '.', '3', '.', '.', '.', '.'],
            ['4', '.', '.', '5', '.', '.', '.', '.', '.'],
            ['1', '9', '8', '.', '.', '.', '.', '.', '3'], // duplicate '1' in column
            ['5', '.', '.', '.', '6', '.', '.', '.', '4'],
            ['.', '.', '.', '8', '.', '3', '.', '.', '5'],
            ['7', '.', '.', '.', '2', '.', '.', '.', '6'],
            ['.', '.', '.', '.', '.', '.', '2', '.', '.'],
            ['.', '.', '.', '4', '1', '9', '.', '.', '8'],
            ['.', '.', '.', '.', '8', '.', '.', '7', '9'],
        ];

        var sudoku = new ValidSudoku();
        var output = sudoku.IsValidSudoku(input);

        Assert.That(output, Is.False);
    }

    [Test]
    public void Should_ReturnFalse_WhenSubgridHasDuplicate()
    {
        char[][] input =
        [
            ['1', '2', '.', '.', '3', '.', '.', '.', '.'],
            ['4', '2', '.', '5', '.', '.', '.', '.', '.'], // duplicate '2' in top-left 3x3 box
            ['.', '9', '8', '.', '.', '.', '.', '.', '3'],
            ['5', '.', '.', '.', '6', '.', '.', '.', '4'],
            ['.', '.', '.', '8', '.', '3', '.', '.', '5'],
            ['7', '.', '.', '.', '2', '.', '.', '.', '6'],
            ['.', '.', '.', '.', '.', '.', '2', '.', '.'],
            ['.', '.', '.', '4', '1', '9', '.', '.', '8'],
            ['.', '.', '.', '.', '8', '.', '.', '7', '9'],
        ];

        var sudoku = new ValidSudoku();
        var output = sudoku.IsValidSudoku(input);

        Assert.That(output, Is.False);
    }

    [Test]
    public void Should_ReturnTrue_ForCompletelyEmptyBoard()
    {
        char[][] input =
        [
            ['.', '.', '.', '.', '.', '.', '.', '.', '.'],
            ['.', '.', '.', '.', '.', '.', '.', '.', '.'],
            ['.', '.', '.', '.', '.', '.', '.', '.', '.'],
            ['.', '.', '.', '.', '.', '.', '.', '.', '.'],
            ['.', '.', '.', '.', '.', '.', '.', '.', '.'],
            ['.', '.', '.', '.', '.', '.', '.', '.', '.'],
            ['.', '.', '.', '.', '.', '.', '.', '.', '.'],
            ['.', '.', '.', '.', '.', '.', '.', '.', '.'],
            ['.', '.', '.', '.', '.', '.', '.', '.', '.'],
        ];

        var sudoku = new ValidSudoku();
        var output = sudoku.IsValidSudoku(input);

        Assert.That(output, Is.True);
    }
}
