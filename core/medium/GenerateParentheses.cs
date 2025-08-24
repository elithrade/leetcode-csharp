namespace core.medium;

public class GenerateParentheses
{
    // Start with an empty string.
    // At each step, you can choose to add ( or ) if valid.
    // Recursively explore both choices.
    // When the string length is 2 * n, add it to results.
    //
    // Rules:
    // 1. Only add ( if open < n
    // 2. Only add ) if close < open
    // 3. Only valid if n = open = close
    public List<string> Generate(int n)
    {
        var result = new List<string>();

        void Backtrack(string current, int open, int close)
        {
            if (current.Length == 2 * n)
            {
                // Add the current combination to the results and stops
                result.Add(current);
                return;
            }

            // Add an opening parenthesis if valid
            if (open < n)
            {
                Backtrack(current + "(", open + 1, close);
            }

            // Recursively add a closing parenthesis if valid
            if (close < open)
            {
                Backtrack(current + ")", open, close + 1);
            }
        }

        Backtrack("", 0, 0);

        return result;
    }
}
