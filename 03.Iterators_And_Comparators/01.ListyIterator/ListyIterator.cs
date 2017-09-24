using System;
using System.Collections.Generic;

class ListyIterator<T>
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

    public bool HasNext()
    {
        if (List.Count > index + 1)
        {
            return true;
        }
        return false;
    }
}

