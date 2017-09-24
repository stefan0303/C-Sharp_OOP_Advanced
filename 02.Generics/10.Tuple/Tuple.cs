using System.Text;

class Tuple<T, U>
{
    private T itemOne;
    private U itemTwo;

    public Tuple(T itemOne, U itemTwo)
    {
        ItemOne = itemOne;
        ItemTwo = itemTwo;
    }

    public T ItemOne
    {
        get { return this.itemOne; }
        private set { this.itemOne = value; }
    }
    public U ItemTwo
    {
        get { return this.itemTwo; }
        private set { this.itemTwo = value; }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"{this.itemOne} -> {this.itemTwo}");
        return sb.ToString();
    }
}

