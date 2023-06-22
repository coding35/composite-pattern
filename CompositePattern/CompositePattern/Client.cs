namespace CompositePattern;

public class Client
{
    readonly Component _root;
    
    public Client(Component root)
    {
        _root = root;
    }
    
    public void Main()
    {
        _root.Operation();
    }
}