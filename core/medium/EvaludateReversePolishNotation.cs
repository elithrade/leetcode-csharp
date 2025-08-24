namespace core.medium;

public class EvaluateReversePolishNotation
{
    public int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();

        var operators = new HashSet<string> { "+", "-", "*", "/" };

        // Input: [1, 2, +, 3, *, -]
        foreach (var token in tokens)
        {
            if (operators.Contains(token))
            {
                // Start popping the apply operator on operands
                // and push the result onto the stack
                var result = Calculate(token, stack.Pop(), stack.Pop());
                stack.Push(result);
            }
            else
            {
                // Push the number onto the stack
                if (!int.TryParse(token, out var number))
                    throw new ArgumentException("Invalid token");

                stack.Push(number);
            }
        }

        // This is the final result
        return stack.Pop();
    }

    private int Calculate(string o, int left, int right)
    {
        if (o == "+")
        {
            return left + right;
        }
        else if (o == "-")
        {
            // For subtraction and division, the order of operands matters
            // [1, 2, -] => 1 - 2, not 2 - 1
            return right - left;
        }
        else if (o == "*")
        {
            return left * right;
        }
        else if (o == "/")
        {
            // For subtraction and division, the order of operands matters
            // [1, 2, /] => 1 / 2, not 2 / 1
            return right / left;
        }
        else
        {
            throw new ArgumentException("Invalid operator");
        }
    }
}
