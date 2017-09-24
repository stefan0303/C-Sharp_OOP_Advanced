using System;

class Scale<T> where T:IComparable<T>
{
    public Scale(T left,T right)
    {
        this.Left = left;
        this.Right = right;
    }

    public T Left { get; set; }
    public T Right { get; set; }
    public T GetHavier()
    {
        if (Right.CompareTo(Left)==1)
        {

            return this.Right;
        }
        if (Right.CompareTo(Left)==-1)
        {
            return this.Left;
        }
        return default(T);
    }
}

