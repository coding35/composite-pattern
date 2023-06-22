namespace CompositePattern;

public abstract class Component
{
  protected string Name { get; set; }
  protected string Description { get; set; }

  private List<Component> Children { get; set; }

  protected Component(string name, string description, List<Component> children)
  {
    Name = name;
    Description = description;
    Children = children;
  }
  
  public void Add(Component component)
  {
    Children.Add(component);
  }
  
  public void Remove(Component component)
  {
    Children.Remove(component);
  }
  
  public Component GetChild(int index)
  {
    return Children[index];
  }

  protected List<Component> GetChildren()
  {
    return Children;
  }

  public string GetName()
  {
    return this.Name;
  }
  
  public string GetDescription()
  {
    return this.Description;
  }
  
  public bool IsComposite()
  {
    return HasChildren();
  }

  private bool HasChildren()
  {
    return Children.Count > 0;
  }

  public abstract void Operation();
}