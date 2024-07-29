using System;
using System.Collections.Generic; // Like STLs librrary

class Program {
    static void Main() {
        // List
        List<int> list = new List<int> { 1, 2, 3 };
        list.Add(4);
        
        // Dictionary
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        dictionary["one"] = 1;
        dictionary["two"] = 2;
        
        // Queue
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        
        // Stack
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        
        // Linked List
        LinkedList<int> linkedList = new LinkedList<int>();
        linkedList.AddLast(1);
        linkedList.AddLast(2);
        linkedList.AddLast(3);
        linkedList.AddLast(4);
    }
}
