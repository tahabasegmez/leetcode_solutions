public class MinStack {

    private Stack<int> _minStack;
    private Stack<int> _stack;

    public MinStack() 
    {
        _minStack = new Stack<int>();  
        _stack = new Stack<int>();
    }
    
    public void Push(int value) {
        _stack.Push(value);
        
        if (_minStack.Count != 0 )
        {
            if (value <= _minStack.Peek())
            {
                _minStack.Push(value);
            }
        }
        else _minStack.Push(value);
    }
    
    public void Pop() {
        if (_stack.TryPop(out int value))
        {
            if (_minStack.Count != 0)
            {
                if (value == _minStack.Peek())
                {
                    _minStack.Pop();
                }
            }
        }
    }
    
    
    public int Top() {
        return _stack.Peek();
    }
    
    public int GetMin() {
        return _minStack.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(value);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */