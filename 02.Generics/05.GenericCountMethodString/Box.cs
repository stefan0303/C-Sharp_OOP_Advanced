using System;
using System.Collections.Generic;
using System.Text;

class Box<T> where T:IComparable<T>
{
    private IList<T> list;
    public Box(T item)
    {
        this.Item = item;
        this.list=new List<T>();
    }

    public T Item { get; set; }

    public void Add(T item)
    {
        list.Add(item);
    }

    public int CompareTo(T itemToCompare)

    {
        int countBig = 0;
        foreach (var item in list)
        {
            if (item.CompareTo(itemToCompare)==1)
            {
                countBig += 1;
            }
        }
        return countBig;

    }

    public void Swap(int first, int second)
    {
        T save = this.list[first];
        this.list[first] = list[second];
        list[second] = save;
    }

    public override string ToString()
    {
        StringBuilder sb =new StringBuilder();
        foreach (var item in list)
        {
            sb.Append(item.GetType().FullName + ": " + item+Environment.NewLine);
        }
        return sb.ToString();
      
    }
}

