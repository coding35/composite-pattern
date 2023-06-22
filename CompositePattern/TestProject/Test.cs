using System.Collections.Generic;
using CompositePattern;
using NUnit.Framework;

namespace TestProject;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Component root = new CompositeNode("root", "root", new List<Component>());
        Component c1 = new CompositeNode("c1.1", "CompositeNode c1.1", new List<Component>());
        Component c2 = new CompositeNode("c1.2", "CompositeNode c1.2", new List<Component>());
        Component c3 = new CompositeNode("c1.3", "CompositeNode c1.3", new List<Component>());
        
        Component c1_1 = new CompositeNode("c1.1.1", "LeafNode c1.1.1", new List<Component>()
        {
            new LeafNode("c1.1.1.1", "LeafNode c1.1.1.1", new List<Component>()),
            new LeafNode("c1.1.1.2", "LeafNode c1.1.1.2", new List<Component>()),
            new CompositeNode("c1.1.1.3", "CompositeNode c1.1.1.3", new List<Component>()
            {
                new LeafNode("c1.1.1.3.1", "LeafNode c1.1.1.3.1", new List<Component>()),
                new LeafNode("c1.1.1.3.2","LeafNode c1.1.1.3.2", new List<Component>())
            })
        });
        Component c1_2 = new LeafNode("c1.1.2", "LeafNode c1.1.2", new List<Component>());
        Component c1_3 = new LeafNode("c1.1.3", "LeafNode c1.1.3", new List<Component>());
        Component c1_4 = new LeafNode("c1.1.4", "LeafNode c1.1.4", new List<Component>());
        
        c1.Add(c1_1);
        c2.Add(c1_2);
        c3.Add(c1_3);
        c3.Add(c1_4);
        
        root.Add(c1);
        root.Add(c2);
        root.Add(c3);
        
        var client = new Client(root);
        
        client.Main();
        
    }
}