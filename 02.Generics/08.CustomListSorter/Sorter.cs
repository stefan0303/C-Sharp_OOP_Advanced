using System;
using System.Linq;
using System.Text;

public class Sorter<T> where T : IComparable<T>
{
    public string Sort(CustomList<T> listToSort )
    {
      
       var custom = listToSort.OrderBy(x => x).ToList();
       StringBuilder sb =new StringBuilder();
        for (int i = 0; i < custom.Count-1; i++)
        {
            listToSort.Remove(i);
        }
        listToSort.Remove(0);
        for (int i = 0; i < custom.Count; i++)
        {
         
            listToSort.Add(custom[i]);
            
            sb.Append(custom[i] + Environment.NewLine);
        }
        return sb.ToString();
    }
}

