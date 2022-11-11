namespace CustomStack;

public class MyStack<T>
{
    private readonly List<T>? _stack;

    public MyStack(List<T>? stack)
    {
        _stack = stack;
    }

    public MyStack(int capacity)
    {
        _stack = new List<T>(capacity);
    }

    /// <summary>
    /// insert element into stack
    /// </summary>
    /// <param name="element">element to be inserted</param>
    public void Push(T element)
    {
        _stack!.Add(element);
    }

    /// <summary>
    /// removes element from stack
    /// </summary>
    /// <returns>element which should be removed</returns>
    /// <exception cref="IndexOutOfRangeException">exception when stack is empty and trying
    /// to remove element</exception>
    public T Pop()
    {
        if (_stack == null || _stack?.Count == 0)
        {
            throw new IndexOutOfRangeException("Stack is empty");
        }

        T element = _stack![^1]; //_stack[_stack.Count-1]
        _stack.RemoveAt(_stack.Count - 1);

        return element;
    }

    public MyStack()
    {
        _stack = new List<T>();
    }

    /// <summary>
    /// returns stack's top element
    /// </summary>
    /// <returns>top element</returns>
    /// <exception cref="IndexOutOfRangeException">if stack is empty throws exception</exception>
    public T Peek()
    {
        if (_stack == null || _stack.Count == 0)
        {
            throw new IndexOutOfRangeException("Stack is empty");
        }

        return _stack[^1];
    }

    public int Size()
    {
        if (_stack == null)
        {
            return 0;
        }

        return _stack.Count;
    }

    /// <summary>
    /// check if stack is empty
    /// </summary>
    /// <returns> <b>true</b>- if stack is empty otherwise <b>false</b></returns>
    public bool IsEmpty()
    {
        return _stack?.Count == 0;
    }
}