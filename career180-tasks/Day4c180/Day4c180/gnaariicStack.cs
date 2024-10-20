using System;

public class MyStack<T>
{
    private T[] elements;
    private int top;
    private int capacity;

    public MyStack(int size)
    {
        elements = new T[size];
        capacity = size;
        top = -1; 
    }

    public void Push(T item)
    {
        if (top == capacity - 1)
        {
            throw new InvalidOperationException("Stack overflow");
        }
        elements[++top] = item;
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack underflow");
        }
        return elements[top--];
    }

    public bool IsEmpty()
    {
        return top == -1;
    }

  
}
