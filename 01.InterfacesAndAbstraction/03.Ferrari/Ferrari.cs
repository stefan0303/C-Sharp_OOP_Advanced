using System.Text;

class Ferrari : ICar
{
    private string name;
    private string model;
    private string driverName;
    public Ferrari(string name, string model, string driverName)
    {
        this.Name = name;
        this.Model = model;
        this.DriverName = driverName;
    }
    public string Name { get; set; }
    public string Model { get; set; }
    public string DriverName { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(this.Model + "/" + this.Brakes() + "/" + this.Gas() + "/" + this.DriverName);
        return sb.ToString();
    }

    public string Brakes()
    {
        return "Brakes!";
    }

    public string Gas()
    {
        return "Zadu6avam sA!";
    }
}

