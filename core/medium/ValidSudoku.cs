namespace core.medium;

public class ValidSudoku
{
    public bool IsValidSudoku(char[][] board)
    {
        var rowMap = new Dictionary<int, HashSet<char>>();
        var columnMap = new Dictionary<int, HashSet<char>>();
        // Indexed by row / 3, and column / 3
        var squareMap = new Dictionary<string, HashSet<char>>();

        // ['1', '2', '.', '.', '3', '.', '.', '.', '.'],
        // ['4', '.', '.', '5', '.', '.', '.', '.', '.'],
        // ['.', '9', '8', '.', '.', '.', '.', '.', '3'],
        // ['5', '.', '.', '.', '6', '.', '.', '.', '4'],
        // ['.', '.', '.', '8', '.', '3', '.', '.', '5'],
        // ['7', '.', '.', '.', '2', '.', '.', '.', '6'],
        // ['.', '.', '.', '.', '.', '.', '2', '.', '.'],
        // ['.', '.', '.', '4', '1', '9', '.', '.', '8'],
        // ['.', '.', '.', '.', '8', '.', '.', '7', '9'],
        for (int row = 0; row < board.Length; row++)
        {
            for (int column = 0; column < board[row].Length; column++)
            {
                if (board[row][column] == '.')
                {
                    continue; // Skip empty cells
                }

                if (!rowMap.TryGetValue(row, out HashSet<char>? rowHashSet))
                {
                    rowHashSet = [];
                    rowMap[row] = rowHashSet;
                }
                if (!columnMap.TryGetValue(column, out HashSet<char>? columnHashSet))
                {
                    columnHashSet = [];
                    columnMap[column] = columnHashSet;
                }

                var squareKey = string.Format(
                    "({0}, {1})",
                    Math.Floor((double)row / 3),
                    Math.Floor((double)column / 3)
                );

                if (!squareMap.TryGetValue(squareKey, out HashSet<char>? squareHasSet))
                {
                    squareHasSet = [];
                    squareMap[squareKey] = squareHasSet;
                }

                var value = board[row][column];

                if (
                    rowHashSet.Contains(value) // Row contains duplicate
                    || columnHashSet.Contains(value) // Column contains duplicate
                    || squareHasSet.Contains(value) // Square contains duplicate
                )
                {
                    return false;
                }

                rowHashSet.Add(value);
                columnHashSet.Add(value);
                squareHasSet.Add(value);
            }
        }

        return true;
    }
}
