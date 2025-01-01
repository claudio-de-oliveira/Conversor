using System.Xml;
using Conversor.Xml;

public class XXmlNode {
    public string? Name { get; set; }
    public List<XXmlAttribute> Attributes { get; } = [];
    public List<XXmlNode> ChildNodes { get; } = [];
    public XmlNode? Node { get; set; }
    public string? Value { get; set; }

    public string Code { get; set; } = "";
}
