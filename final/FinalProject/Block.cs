public class Block
{
    public Block() { }

    public Block(string name, int value)
    {
        Name = name;
        Value = value;
    }

    public string Name { get; set; }
    public int Value { get; set; }

    public string GetName()
    {
        return Name;
    }

    public int GetColorValue()
    {
        return Value;
    }
}
