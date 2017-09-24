using System.Collections;
using System.Collections.Generic;

public class Lake<T> : IEnumerable<T>
{
    public IList<T> List;

    public Lake()
    {
        List = new List<T>();
    }

    public void Add(T elementh)
    {
        List.Add(elementh);
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < List.Count; i++)
        {
            if (i % 2 == 0)
            {
                yield return List[i];
            }
        }
        for (int i = List.Count - 1; i >= 0; i--)
        {
            if (i % 2 != 0)
            {
                yield return List[i];
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
