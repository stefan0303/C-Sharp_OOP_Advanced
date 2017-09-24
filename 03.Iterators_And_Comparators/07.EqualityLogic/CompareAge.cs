using System.Collections.Generic;

class CompareAge : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        if (x?.Age > y?.Age)
        {
            return 1;
        }
        if (x?.Age == y?.Age)
        {
            return 0;
        }
        return -1;
    }
}

