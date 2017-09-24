using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Stack<T> : IEnumerable<T>
{
    public IList<T> List;

    public Stack()
    {
        List = new List<T>();
    }
    public void Push(T elementh)
    {
        List.Add(elementh);
    }
    public void Pop()
    {
        if (List.Count == 0)
        {
            Console.WriteLine("No elements");
        }
        else
        {
            List.Remove(List.Last());
        }
    }
    public IEnumerator<T> GetEnumerator()
    {
        for (int i = List.Count - 1; i >= 0; i--)
        {
            yield return List[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

