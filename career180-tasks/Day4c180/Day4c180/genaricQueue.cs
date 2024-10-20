using System;
using System.Collections.Generic;

public class GenericQueue<T>
{
    private List<T> elements = new List<T>(); 

    public void push(T item)
    {
        elements.Add(item); 
    }

    public T pop()
    {
        if (elements.Count == 0)
            throw new InvalidOperationException("Queue is empty.");

        T value = elements[0]; 
        return value;
    }
}
