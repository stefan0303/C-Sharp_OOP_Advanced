using System.Collections;
using System.Collections.Generic;

class LinkedList<T>:IEnumerable<T>
{
    public readonly IList<T> List;

    public LinkedList()
    {
        this.List=new List<T>();
    }
    public void Add(T elementh)
    {
        this.List.Add(elementh);
    }

    public bool Remove(T elementh)
    {
        if (List.Contains(elementh))
        {
            this.List.Remove(elementh);
            return true;
        }
        return false;

    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < List.Count; i++)
        {
            yield return this.List[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

