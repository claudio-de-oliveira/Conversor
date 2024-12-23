using Conversor.Atributos;

public class XXmlNode {
    public string? Name { get; set; }
    public Dictionary<string, XXmlAttribute> Attributes { get; } = [];
    public Dictionary<string, XXmlNode> ChildNodes { get; } = [];
    public string? Value { get; set; }
}