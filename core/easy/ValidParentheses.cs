namespace core.easy;

public class ValidParentheses
{
    public bool IsValid(string s)
    {
        // Create a stack to push and pop characters
        // If the input is a valid parentheses string, it should be empty at the end
        Stack<char> stack = new();

        // Input: "([{}])"
        var openToClose = new Dictionary<char, char>
        {
            { '(', ')' },
            { '[', ']' },
            { '{', '}' },
        };

        foreach (var c in s)
        {
            if (openToClose.ContainsKey(c))
            {
                // If it's an opening bracket, push it onto the stack
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0)
                    return false; // Unmatched closing bracket

                // For closing brackets, check if the top of the stack matches
                var open = stack.Pop();
                if (openToClose[open] != c)
                    return false; // Mismatched or unbalanced parentheses
            }
        }

        return stack.Count == 0;
    }
}
