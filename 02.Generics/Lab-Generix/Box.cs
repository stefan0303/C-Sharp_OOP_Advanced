using System.Collections.Generic;
using System.Linq;

public class Box<T>
{
    private IList<T> data;
    public Box()
    {
        this.data = new List<T>();
       
    }
    public void Add(T elementh)
    {

        this.data.Add(elementh);
    }

    public T Remove()
    {
        var remove = data.LastOrDefault();
        data.RemoveAt(data.Count-1);
        return remove;
    }

    public int Count
    {
        get { return this.data.Count; }
    }
}

