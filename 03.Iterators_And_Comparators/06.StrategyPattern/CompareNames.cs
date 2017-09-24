using System.Collections.Generic;

class CompareNames : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        string xPersonName = x.Name.ToLower();
        string yPersonName = y.Name.ToLower();
        if (xPersonName.Length > yPersonName.Length)
        {
            return 1;
        }
        if (xPersonName.Length == yPersonName.Length)
        {
            char xName = xPersonName[0];
            char yName = yPersonName[0];
            if (xName > yName)
            {
                return 1;
            }

            return -1;

        }
        return -1;
    }
}

