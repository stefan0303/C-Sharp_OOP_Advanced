using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class CustomList<T> : ICustomList<T>,IEnumerable<T>
    where T : IComparable<T>
{
    private readonly IList<T> elements;

    public CustomList()
    {
        this.elements = new List<T>();
    }
    public void Add(T element)
    {
        this.elements.Add(element);
    }

    public void Remove(int index)
    {
        var element = elements[index];
        elements.RemoveAt(index);
        
    }

    public bool Contains(T element)
    {
        if (elements.Contains(element))
        {
            return true;
        }
        return false;
    }

    public void Swap(int index1, int index2)
    {
        var element = elements[index1];
        elements[index1] = elements[index2];
        elements[index2] = element;
    }

    public int CountGreaterThan(T element)
    {
        int count = 0;
        foreach (var e in elements)
        {
            if (e.CompareTo(element)==1)
            {
                count++;
            }
        }
        return count;
    }

    public T Max()
    {
        var maxElement = elements.Max();
        return maxElement;
    }

    public T Min()
    {
        var minElement = elements.Min();
        return minElement;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return elements.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

 
}


