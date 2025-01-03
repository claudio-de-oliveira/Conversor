namespace Conversor.Generator;

public static class CodeGenerator {

    public static void GenerateNodeXContextBase(StreamWriter escritor)
    {
        string palavras = "/home/claudio/Source/Conversor/Conversor/docs/palavras.txt";

        Dictionary<string, XmlKeyModel> models = [];

        string[] linhas = File.ReadAllLines(palavras);
        foreach (string linha in linhas)
        {
            if (string.IsNullOrWhiteSpace(linha))
            {
                continue;
            }
            if (XmlKeyModel.TryParse(linha, out XmlKeyModel? model))
            {
                if (models.ContainsKey(model!.Key))
                    escritor.WriteLine("// Linha repetida: " + linha);
                else
                    models.Add(model!.Key, model!);
                model = null;
            }
            else
            {
                escritor.WriteLine("// Linha inválida: " + linha);
            }
        }
        escritor.WriteLine("   /// <summary>");
        escritor.WriteLine("   /// Recursively processes an XML node and its children. ");
        escritor.WriteLine("   /// It first processes all children, and then calls the ");
        escritor.WriteLine("   /// appropriate ProcessXXXNode method based on the node's name.");
        escritor.WriteLine("   /// </summary>");
        escritor.WriteLine("   /// <param name=\"node\">The XXmlNode to process.</param>");
        escritor.WriteLine("   private void ProcessNodeInternal(XXmlNode xnode)");
        escritor.WriteLine("   {");
        escritor.WriteLine("       if (xnode.Attributes != null)");
        escritor.WriteLine("           foreach (var attribute in xnode.Attributes)");
        escritor.WriteLine("               ProcessAttributeInternal(xnode, attribute);");
        escritor.WriteLine("       if (xnode.ChildNodes != null)");
        escritor.WriteLine("           foreach (var childNode in xnode.ChildNodes)");
        escritor.WriteLine("               ProcessNodeInternal(childNode);");
        escritor.WriteLine("");
        escritor.WriteLine("       if (xnode.Code == \"\")");
        escritor.WriteLine("       {");
        escritor.WriteLine("           string name = xnode.Name!;");
        escritor.WriteLine("           if (name.Contains('.'))");
        escritor.WriteLine("               name = name.Split('.')[0];");
        escritor.WriteLine("           if (name.Contains(':'))");
        escritor.WriteLine("               name = name.Split(':')[1];");
        escritor.WriteLine("");
        escritor.WriteLine("           switch(name)");
        escritor.WriteLine("           {");
        foreach (string key in models.Keys)
        {
            escritor.WriteLine("               case \"" + key + "\":");
            escritor.WriteLine("                   On" + key + "Node(xnode);");
            escritor.WriteLine("                   break;");
        }
        escritor.WriteLine("               //");
        escritor.WriteLine("               default:");
        escritor.WriteLine("                   OnDefaultNode(xnode);");
        escritor.WriteLine("                   break;");
        escritor.WriteLine("           }");
        escritor.WriteLine("       }");
        escritor.WriteLine("   }");
        escritor.WriteLine("");
        foreach (string key in models.Keys)
        {
            escritor.WriteLine($"   public virtual void On{key}Node(XXmlNode xnode) {{}}");
        }
        escritor.WriteLine("   public abstract void OnDefaultNode(XXmlNode xnode);");
        escritor.WriteLine("");
    }

    public static void GenerateAttributeXContextBase(StreamWriter escritor)
    {
        string palavras = "/home/claudio/Source/Conversor/Conversor/docs/attributes.txt";

        string[] linhas = File.ReadAllLines(palavras);

        escritor.WriteLine("   /// <summary>");
        escritor.WriteLine("   /// Recursively processes an XML attribute and its children. ");
        escritor.WriteLine("   /// It first processes all children, and then calls the ");
        escritor.WriteLine("   /// appropriate ProcessXXXAttribute method based on the node's name.");
        escritor.WriteLine("   /// </summary>");
        escritor.WriteLine("   /// <param name=\"node\">The XXmlNode to process.</param>");
        escritor.WriteLine("   private void ProcessAttributeInternal(XXmlNode xnode, XXmlAttribute xattribute)");
        escritor.WriteLine("   {");
        escritor.WriteLine("       switch(xattribute.Name)");
        escritor.WriteLine("       {");
        foreach (string key in linhas)
        {
            var name = key.Trim();
            escritor.WriteLine("           case \"" + name + "\":");
            escritor.WriteLine("               On" + name + "Attribute(xnode, xattribute);");
            escritor.WriteLine("               break;");
        }
        escritor.WriteLine("           //");
        escritor.WriteLine("           default:");
        escritor.WriteLine("               OnDefaultAttribute(xnode, xattribute);");
        escritor.WriteLine("               break;");
        escritor.WriteLine("       }");
        escritor.WriteLine("   }");
        escritor.WriteLine("");
        foreach (string key in linhas)
        {
            var name = key.Trim();
            escritor.WriteLine($"   public virtual void On{name}Attribute(XXmlNode xnode, XXmlAttribute xattribute) {{}}");
        }
        escritor.WriteLine("   public abstract void OnDefaultAttribute(XXmlNode xnode, XXmlAttribute xattribute);");
    }

    public static void GenerateXContextBase(string path)
    {
        Dictionary<string, XmlKeyModel> models = [];

        try
        {
            using var escritor = new StreamWriter(path);

            escritor.WriteLine("// ####################################");
            escritor.WriteLine("// ESSE CÓDIGO É GERADO AUTOMATICAMENTE");
            escritor.WriteLine("// ****** NÃO ALTERE ESTE CÓDIGO ******");
            escritor.WriteLine("// ####################################");
            escritor.WriteLine("");
            escritor.WriteLine("namespace Conversor.Xml;");
            escritor.WriteLine("");
            escritor.WriteLine("public abstract class XContextBase");
            escritor.WriteLine("{");
            escritor.WriteLine("   /// <summary>");
            escritor.WriteLine("   /// Recursively processes an XML node and its children. ");
            escritor.WriteLine("   /// It first checks if the node has children, and if so, ");
            escritor.WriteLine("   /// calls itself on each child node. After processing all ");
            escritor.WriteLine("   /// children, it calls the ProcessNode method on the ");
            escritor.WriteLine("   /// original node.");
            escritor.WriteLine("   /// </summary>");
            escritor.WriteLine("   /// <param name=\"xnode\">The XXmlNode to process.</param>");
            escritor.WriteLine("   public void ProcessNode(XXmlNode xnode)");
            escritor.WriteLine("   {");
            escritor.WriteLine("       if (xnode.ChildNodes != null)");
            escritor.WriteLine("           foreach (var node in xnode.ChildNodes)");
            escritor.WriteLine("               ProcessNode(node);");
            escritor.WriteLine("");
            escritor.WriteLine("       ProcessNodeInternal(xnode);");
            escritor.WriteLine("   }");
            escritor.WriteLine("");
            GenerateNodeXContextBase(escritor);
            GenerateAttributeXContextBase(escritor);
            escritor.WriteLine("}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}