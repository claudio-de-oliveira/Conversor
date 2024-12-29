using Conversor.Xml;

namespace Conversor.Flutter;

public class XFlutterContext : XContextBase
{
    public override void OnGrid(XXmlNode xnode)
    {
        var attributes = xnode.Attributes;
        var children = xnode.ChildNodes;
    }

    public override void OnWindow(XXmlNode xnode)
    {
        var attributes = xnode.Attributes;
        var children = xnode.ChildNodes;
    }

    public override void OnDefaultNode(XXmlNode xnode)
    {
        var attributes = xnode.Attributes;
        var children = xnode.ChildNodes;

        // Do something
    }
}