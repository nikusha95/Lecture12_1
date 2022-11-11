namespace CustomStack;

public class Test
{
    public string Name { get; set; }
    public int IntegerNumber { get; set; }

    public override string ToString()
    {
        return $"name:{Name} integer:{IntegerNumber}";
    }
}