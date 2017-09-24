using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

class ListyIterator<T> : IEnumerable<T>
{
    public static int index = 0;
    public ListyIterator(params T[] list)
    {
        this.List = new List<T>(list);
    }
    public IReadOnlyList<T> List { get; set; }


    public bool Move()
    {
        int currentIndex = index + 1;

        if (List.Count > currentIndex)
        {
            index += 1;
            return true;
        }
        return false;
    }

    public void Print()
    {
        if (List.Count == 0)
        {
            Console.WriteLine("Invalid Operation!");
        }
        else
        {
            Console.WriteLine(List[index]);
        }
    }

    public string PrintAll()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var item in List)
        {
            sb.Append(List.GetEnumerator() + " ");
        }
        return sb.ToString();
    }

    public bool HasNext()
    {
        if (List.Count > index + 1)
        {
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

