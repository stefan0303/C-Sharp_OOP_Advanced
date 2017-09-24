
class Person
{

    private string name;
    private int age;

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;

    }
    public string Name
    {
        get { return this.name; }
        private set { this.name = value; }
    }
    public int Age
    {
        get { return this.age; }
        private set { this.age = value; }
    }

    public override string ToString()
    {
        return $"{this.Name} {this.Age}";
    }
    public override bool Equals(object obj)
    {
        var item = obj as Person;

        if (item == null)
        {
            return false;
        }
        if (this.Name.Equals(item.Name) && this.Age.Equals(item.Age))
        {
            return true;
        }
        return false;
    }

    public override int GetHashCode()
    {

        return this.Name.GetHashCode();
    }
}

