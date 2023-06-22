namespace CompositePattern;

public class CompositeNode : Component
{
    public CompositeNode(string name, string description, List<Component> children) :
        base(name, description, children)
    {
    }
    
    public override void Operation()
    {
        var tab = IsComposite() ? "\t" : "";
        
        Console.WriteLine($"{tab}CompositeNode: {Name} - {Description}");
        foreach (var child in GetChildren())
        {
            child.Operation();
        }
    }


}