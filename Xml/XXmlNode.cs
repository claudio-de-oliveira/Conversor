using Conversor.Xml;

public class XXmlNode {
    public string? Name { get; set; }
    public List<XXmlAttribute> Attributes { get; } = [];
    public List<XXmlNode> ChildNodes { get; } = [];
    public string? Value { get; set; }
}