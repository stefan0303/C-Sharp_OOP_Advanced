using System.Text;

class Tuple<T, U, G>
{
    private T itemOne;
    private U itemTwo;
    private G itemThree;
    public Tuple(T itemOne, U itemTwo, G itemThree)
    {
        this.ItemOne = itemOne;
        this.ItemTwo = itemTwo;
        this.itemThree = itemThree;
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

    public G ItemThree
    {
        get { return this.itemThree; }
        private set { this.itemThree = value; }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"{this.itemOne} -> {this.itemTwo} -> {this.ItemThree}");
        return sb.ToString();
    }
}

