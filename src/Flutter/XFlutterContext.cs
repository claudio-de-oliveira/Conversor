using Conversor.Xml;

namespace Conversor.Flutter;

public class XFlutterContext : XContextBase
{
    public override void OnGrid(XXmlNode xnode)
    {
        var attributes = xnode.Attributes;
        var children = xnode.ChildNodes;

        xnode.Code = $"Código gerado a partir do {xnode.Name}";
    }

    public override void OnWindow(XXmlNode xnode)
    {
        var attributes = xnode.Attributes;
        var children = xnode.ChildNodes;

        xnode.Code = $"Código gerado a partir do {xnode.Name}";
    }
 
    public override void OnDefaultNode(XXmlNode xnode)
    {
        var attributes = xnode.Attributes;
        var children = xnode.ChildNodes;

        xnode.Code = $"Código gerado a partir do {xnode.Name}";
    }
 
    public override void OnIdealSoftTextBox(XXmlNode xnode)
    {
        var attributes = xnode.Attributes;
        var children = xnode.ChildNodes;

        xnode.Code = $"Código gerado a partir do {xnode.Name}";
    }
}