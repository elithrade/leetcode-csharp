namespace core.medium;

public class TwoStacks
{
    private readonly Stack<int> _stack;
    private readonly Stack<int> _minStack;

    public TwoStacks()
    {
        _stack = new Stack<int>();
        _minStack = new Stack<int>();
    }

    public void Push(int val)
    {
        _stack.Push(val);
        if (_minStack.Count > 0 && _minStack.Peek() >= val)
        {
            // Found the new minimum, push it onto the min stack
            _minStack.Push(val);
        }
        else if (_minStack.Count == 0)
        {
            // First element, push it onto the min stack
            _minStack.Push(val);
        }
        else
        {
            // Keep the current minimum on the min stack
            _minStack.Push(_minStack.Peek());
        }
    }

    public void Pop()
    {
        _stack.Pop();
        _minStack.Pop();
    }

    public int Top()
    {
        return _stack.Peek();
    }

    public int GetMin()
    {
        return _minStack.Peek();
    }
}
