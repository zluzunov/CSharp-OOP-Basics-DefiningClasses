public class Cargo
{
    public string Type { get; set; }
    public int Weight { get; set; }

    public Cargo(int weight, string type)
    {
        this.Weight = weight;
        this.Type = type;
    }
}