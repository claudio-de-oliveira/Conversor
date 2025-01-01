using Conversor.Xml;

namespace Conversor.Flutter;

public class XFlutterContext : XContextBase
{
    public override void OnGridNode(XXmlNode xnode)
    {
        var attributes = xnode.Attributes;
        var children = xnode.ChildNodes;

        if (xnode.Name!.Contains('.'))
        {
            string[] split = xnode.Name.Split('.');

            switch(split[1])
            {
                case "ColumnDefinitions":
                    break;
                case "RowDefinitions":
                    break;
                default:
                    break;
            }
        }
        else
        {
            // ProcessAttributes(xnode);
        }

        xnode.Code = $"Código gerado a partir do {xnode.Name}";
    }

    public override void OnWindowNode(XXmlNode xnode)
    {
        var attributes = xnode.Attributes;
        var children = xnode.ChildNodes;

        if (xnode.Name!.Contains('.'))
        {
            string[] split = xnode.Name.Split('.');

            switch(split[1])
            {
                case "#comment":
                    break;
                case "Resources":
                    break;
                default:
                    break;
            }
        }
        else
        {
            ProcessAttributes(xnode);
        }

        xnode.Code = $"Código gerado a partir do {xnode.Name}";
    }
 
    public override void OnDefaultNode(XXmlNode xnode)
    {
        var attributes = xnode.Attributes;
        var children = xnode.ChildNodes;

        xnode.Code = $"Código gerado a partir do {xnode.Name}";
        Console.WriteLine(xnode.Name);
    }
 
    public override void OnIdealSoftTextBoxNode(XXmlNode xnode)
    {
        var attributes = xnode.Attributes;
        var children = xnode.ChildNodes;

        xnode.Code = $"Código gerado a partir do {xnode.Name}";
    }

   public override void OnUseLayoutRoundingAttribute(XXmlNode xnode, XXmlAttribute xattribute) {

   }

   public override void OnDefaultAttribute(XXmlNode xnode, XXmlAttribute xattribute){

   }

}