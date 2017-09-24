using System;
using System.Linq;

public class Sorter<T> where T : IComparable<T>
{
    public void Sort(CustomList<T> listToSort )
    {      
       var custom = listToSort.OrderBy(x => x).ToList();   

        while (listToSort.Count()!=0)//Remove all elements from listToSort
        {           
            listToSort.Remove(0);       
        }
        for (int i = 0; i < custom.Count; i++)//Add sorted elements
        {  
            listToSort.Add(custom[i]);
                       
        }       
    }
}

