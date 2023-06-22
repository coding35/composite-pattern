namespace CompositePattern;

public class LeafNode : Component
{
    private int Value { get; set; }
    
    public LeafNode(string name, string description, List<Component> children) :
        base(name, description, children)
    {
    }
    
    public int GetValue()
    {
        return Value;
    }
    
    public void SetValue(int value)
    {
        Value = value;
    }
    
    public override void Operation()
    {
        var tab = IsComposite() ? "\t" : "\t\t";

        
        Console.WriteLine($"{tab}LeafNode: {Name} - {Description} - {Value}");
    }
}